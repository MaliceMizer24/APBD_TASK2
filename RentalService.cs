using APBD_TASK2.Database;

namespace APBD_TASK2;

public class RentalService : IRentalService
{
    private readonly Singleton _db = Singleton.Instance;

    public void AddUser(User user)
    {
        _db.Users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        _db.Equipment.Add(equipment);
    }

    public List<Equipment> GetAllEquipment()
    {
        return _db.Equipment;
    }

    public List<Equipment> GetAvailableEquipment()
    {
        return _db.Equipment
            .Where(e => e.status == EquipmentStatus.Available)
            .ToList();
    }

    public void RentEquipment(User user, Equipment equipment, int days)
    {
        ValidateEquipmentAvailable(equipment);
        ValidateUserLimit(user);

        var rental = new Rental(user, equipment, DateTime.Now.Add(new TimeSpan(days)));

        equipment.status = EquipmentStatus.Rented;
        _db.Rentals.Add(rental);
    }

    public void ReturnEquipment(Equipment equipment)
    {
        var rental = FindActiveRental(equipment);

        rental.ReturnDate = DateTime.Now;
        equipment.status = EquipmentStatus.Available;

        var penalty = rental.CalculatePenalty();

        if (penalty > 0)
        {
            Console.WriteLine($"Penalty: {penalty}");
        }
    }

    public List<Rental> GetUserRentals(User user)
    {
        return _db.Rentals
            .Where(r => r.User == user && !r.IsReturned)
            .ToList();
    }

    public List<Rental> GetOverdueRentals()
    {
        return _db.Rentals
            .Where(r => r.IsOverdue)
            .ToList();
    }

    public string GenerateReport()
    {
        int total = _db.Equipment.Count;
        int available = _db.Equipment.Count(e => e.status == EquipmentStatus.Available);
        int rented = _db.Equipment.Count(e => e.status == EquipmentStatus.Rented);
        int overdue = _db.Rentals.Count(r => r.IsOverdue);

        return ("Total equipment: " + total + " Available: " + available + " Rented: " + rented + " Overdue rentals: " +
                overdue);
    }
    
    private void ValidateEquipmentAvailable(Equipment equipment)
    {
        if (equipment.status != EquipmentStatus.Available)
            throw new Exception("Equipment is not available");
    }

    private void ValidateUserLimit(User user)
    {
        int activeRentals = _db.Rentals
            .Count(r => r.User == user && !r.IsReturned);

        int limit = GetUserLimit(user);

        if (activeRentals >= limit)
            throw new Exception("User exceeded rental limit");
    }

    private int GetUserLimit(User user)
    {
        return user.UserType == UserType.Student ? 2 : 5;
    }

    private Rental FindActiveRental(Equipment equipment)
    {
        var rental = _db.Rentals
            .FirstOrDefault(r => r.Equipment == equipment && !r.IsReturned);

        if (rental == null)
            throw new Exception("No active rental found");

        return rental;
    }
}