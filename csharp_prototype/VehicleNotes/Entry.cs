namespace csharp_prototype;

public abstract class Entry
{
    public Guid _entryId {get; init;}
    private DateOnly _date;
    private decimal _cost;
    private int _odometerReading;
    private string _description;
    private Vehicle _vehicle;
    
    public Entry(Vehicle vehicle, DateOnly date, decimal cost, int oreading)
    {
        _vehicle = vehicle; _date = date; _cost = cost;
        _entryId = Guid.NewGuid();
        _odometerReading = oreading;
        vehicle.UpdateOdomenter(_odometerReading);
    }
    public Entry(Vehicle vehicle, DateOnly date, decimal cost)
    {
        _vehicle = vehicle; _date = date; _cost = cost;
        _entryId = Guid.NewGuid();
    }
    
}