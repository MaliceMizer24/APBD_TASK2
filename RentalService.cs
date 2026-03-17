using APBD_TASK2.Database;

namespace APBD_TASK2;

public class RentalService : IRentalService
{
    public void AddUser(User user)
    {
        Singleton.Instance.Users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        Singleton.Instance.Equipment.Add(equipment);
    }

    public List<User> GetUsers()
    {
        Singleton.Instance.Users.Sort();
        return Singleton.Instance.Users;
    }

    public List<Equipment> GetEquipment()
    {
        Singleton.Instance.Equipment.Sort();
        return Singleton.Instance.Equipment;
    }

    public string GenerateReport()
    {
        return "report placeholder";
    }
}