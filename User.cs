namespace APBD_TASK2;

public class User
{
    private static int _nextId = 0;
    
    public int Id { get; }
    
    public string FirstName { get; }
    
    public string LastName { get; }
    
    public string Email { get; }
    public UserType UserType { get; }
    
    public User(string firstName, string lastName, string email, UserType userType)
        {
            Id = _nextId;
            _nextId++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserType = userType;
        }
}