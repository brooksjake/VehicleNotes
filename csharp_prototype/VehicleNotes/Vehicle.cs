
namespace csharp_prototype;

public class Vehicle
{
    // Base information
    private Driver _owner;
    private int _year;
    private string _make;
    private string _model;
    private string _vin;
    
    // Extended information
    public string licensePlateNumber;
    public int currentOdometerReading;
    public string registeredState;
    public DateOnly registrationEndDate;
    public string insurancePolicyNumber;
    private List<Entry> entries;
    
    public Vehicle(Driver owner, int year, string make, string model, string vin)
    {
        _owner = owner; _year = year; _make = make; _model = model; _vin = vin;
        currentOdometerReading = 0; entries = new List<Entry>();
        _owner.AddVehicle(this);
    }
    
    // internal static void TransferOwnership(Driver prevOwner, Vehicle vehicle, Driver newOwner)
    // {
    //     prevOwner.RemoveVehicle(vehicle);
    //     newOwner.AddVehicle(vehicle);
    //     vehicle._owner = newOwner;
    // }
    public void CompleteVehicleSetup (string plate, string state, string policynum, DateOnly registrationend)
    {
        licensePlateNumber = plate; registeredState = state; insurancePolicyNumber = policynum;
        registrationEndDate = registrationend;
        // create and add a 1st new entry, for odometer start???
    }
    
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
        // include odometerreading update???
    }
    
    public void UpdateOdomenter(int oreading)
    {
        if (oreading > currentOdometerReading) currentOdometerReading = oreading;
    }
    
    //public bool RegistrationValid()
}