namespace APBD_TASK2;

public interface IRentalService
{
    void AddUser(User user);
    void AddEquipment(Equipment equipment);

    void RentEquipment(User user, Equipment equipment, int days);
    void ReturnEquipment(Equipment equipment);

    List<Equipment> GetAllEquipment();
    List<Equipment> GetAvailableEquipment();

    List<Rental> GetUserRentals(User user);
    List<Rental> GetOverdueRentals();

    string GenerateReport();
}