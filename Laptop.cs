namespace APBD_TASK2;

public class Laptop : Equipment
{
    public int RamSize { get; set; }
    
    public int ScreenSize { get; set; }
    
    public Laptop(string name, string description, int ramSize, int screenSize)
        : base(name, description)
    {
        RamSize = ramSize;
        ScreenSize = screenSize;
    }
}