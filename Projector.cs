namespace APBD_TASK2;

public class Projector : Equipment
{
    public int Resolution { get; set; }
    public Projector(string name, string description, int resolution) : base(name, description)
    {
        Resolution = resolution;
    }
}