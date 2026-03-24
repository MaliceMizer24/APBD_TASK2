namespace APBD_TASK2;

public class Camera : Equipment
{
    public float SensorQuality { get; set; }

    public Camera(string name, string description, float sensorQuality) : base(name, description)
    {
        SensorQuality = sensorQuality;
    }
}