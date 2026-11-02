namespace csharp_prototype;
public class Driver
{
    public string firstname {get; init;}
    public string lastname {get; init;}
    private DateOnly _birthdate;
    public List<Vehicle> vehicles;
    private string _licenseNumber;
    
    public Driver (string fname, string lname, DateOnly bday, string licenseNumber)
    {
        firstname = fname; lastname = lname; _birthdate = bday; _licenseNumber = licenseNumber;
        vehicles = new List<Vehicle>();
    }
    public void AddVehicle (Vehicle v) { vehicles.Add(v); }
    public void RemoveVehicle (Vehicle v) { vehicles.Remove(v); }
}