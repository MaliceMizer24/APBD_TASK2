namespace APBD_TASK2;

abstract class Equipment
{
    private static int _nextId = 0;
    
    public int Id { get; }
    
    public string Name { get; }
    
    public string Description { get; }
    
    public EquipmentStatus status { get; set; }
    
    public DateTime AddedDate { get; set; }
    public Equipment(string name, string description = "")
    {
        Id = _nextId;
        _nextId++;
        Name = name;
        Description = description;
    }
}