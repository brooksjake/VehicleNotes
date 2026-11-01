

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
    }
    
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
        // include odometerreading update???
    }
    
    //public bool RegistrationValid()
    
    
}