namespace APBD_TASK2;

public interface IRentalService
{
    void AddUser(User user);
    void AddEquipment(Equipment equipment);
    
    List<User> GetUsers();
    List<Equipment> GetEquipment();
    
    string GenerateReport();
}