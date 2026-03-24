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
    
    public bool IsReturned => ReturnDate != null;

    public bool IsOverdue =>
        !IsReturned && DateTime.Now > DueDate;

    public decimal CalculatePenalty()
    {
        if (ReturnDate == null || ReturnDate <= DueDate)
            return 0;

        int daysLate = (ReturnDate.Value - DueDate).Days;
        return daysLate * 10;
    }
    
}
