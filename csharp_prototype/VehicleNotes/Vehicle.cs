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
    
    private Vehicle(Driver owner, int year, string make, string model, string vin)
    {
        _owner = owner; _year = year; _make = make; _model = model; _vin = vin;
        currentOdometerReading = 0;
    }
    
    public static Vehicle ConsoleCreate(Driver d)
    {
        Console.WriteLine("---input the new vehicle information---");
        Console.Write("year:  "); int y = int.Parse(Console.ReadLine());
        Console.Write("make:  "); string ma = Console.ReadLine();
        Console.Write("model:  "); string mo = Console.ReadLine();
        Console.Write("vin:  "); string vin = Console.ReadLine();
        Vehicle v = new Vehicle(d, y, ma, mo, vin);
        v.StartAdministration();
        return v;
    }
    
    public void StartAdministration()
    {
        Console.WriteLine("---input the new vehicle's administrative information---");
        Console.Write("license plate:  "); licensePlateNumber = Console.ReadLine();
        Console.Write("registered state abbreviation:  "); registeredState = Console.ReadLine();
        Console.Write("insurace policy number:  "); insurancePolicyNumber = Console.ReadLine();
        Console.Write("registration end date (yyyy-dd-mm):  ");
        string[] fulldate = Console.ReadLine().Split("-");
        registrationEndDate = new DateOnly(int.Parse(fulldate[0]), int.Parse(fulldate[1]), int.Parse(fulldate[2]));
        
        // create and add a 1st new entry, for odometer start???
    }
    
    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
        // include odometerreading update???
    }
    
    //public bool RegistrationValid()
    
    
}