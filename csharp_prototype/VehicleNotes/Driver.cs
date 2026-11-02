namespace csharp_prototype;
public class Driver
{
    private string _firstname;
    private string _lastname;
    private DateOnly _birthdate;
    public List<Vehicle> vehicles;
    public StatisticsService stats;
    private string _licenseNumber;
    
    public Driver (string firstname, string lastname, DateOnly bday, string licenseNumber)
    {
        _firstname = firstname; _lastname = lastname; _birthdate = bday; _licenseNumber = licenseNumber;
    }
    
    public void CreateNewVehicle()
    {
        vehicles.Add(Vehicle.ConsoleCreate(this));
    }
    public void TransferOwnerShip(Vehicle v)
    {
        
    }
}