namespace APBD_TASK2;

class Program
{
    static void Main()
    {
        var service = new RentalService();

        var student = new User("John", "Doe", "john@mail.com", UserType.Student);
        var employee = new User("Anna", "Smith", "anna@mail.com", UserType.Employee);

        service.AddUser(student);
        service.AddUser(employee);

        var laptop = new Laptop("Dell XPS", "Office laptop", 16, 15);

        service.AddEquipment(laptop);
        
        service.RentEquipment(student, laptop, 3);
        
        try
        {
            service.RentEquipment(employee, laptop, 2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        service.ReturnEquipment(laptop);

        Console.WriteLine(service.GenerateReport());
    }
}