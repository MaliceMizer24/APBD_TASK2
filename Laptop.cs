namespace APBD_TASK2;

public class Laptop
{
    public int RamSize { get; set; }
    
    public int ScreenSize { get; set; }
    
    public Laptop(int ramSize, int screenSize)
        {
        RamSize = ramSize;
        ScreenSize = screenSize;
        }
}