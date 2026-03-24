using APBD_TASK2;

public class Rental
{
    public User User { get; }
    public Equipment Equipment { get; }
    public DateTime RentalDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; set; }

    public Rental(User user, Equipment equipment, DateTime dueDate)
    {
        User = user;
        Equipment = equipment;
        RentalDate = DateTime.Now;
        DueDate = dueDate;
    }
}
