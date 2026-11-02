using System;
namespace csharp_prototype;

internal class Program
{
    // This class will be responsible for interacting with the User
    
    // public StatisticsService stats;
    static void Main(string[] args)
    {
        Driver driver = new Driver("Jesse", "Pinkman", new DateOnly(1998, 11, 4), "3148401451");
        ConstructNewVehicle(driver);
        ConstructNewVehicle(driver);
        
        Console.WriteLine(driver.vehicles);
        
    }
    
    public static void ConstructNewVehicle(Driver owner)
    {
        Console.WriteLine("\nHello, " + owner.firstname + "!");
        Console.WriteLine("Let's create your new vehicle");
        // Asking the user to input the Essential Identity of the vehicle
        Console.WriteLine("---input the new vehicle information---");
        Console.Write("year:  "); int y = int.Parse(Console.ReadLine());
        Console.Write("make:  "); string ma = Console.ReadLine();
        Console.Write("model:  "); string mo = Console.ReadLine();
        Console.Write("vin:  "); string vin = Console.ReadLine();
        Vehicle v = new Vehicle(owner, y, ma, mo, vin);
        
        // Asking the user to input the Additional Information for the vehicle
        Console.WriteLine("---input the new vehicle's administrative information---");
        Console.Write("license plate:  "); string lp = Console.ReadLine();
        Console.Write("registered state abbreviation:  "); string st = Console.ReadLine();
        Console.Write("insurace policy number:  "); string pol = Console.ReadLine();
        Console.Write("registration end date (yyyy-mm-dd):  ");
        string[] fulldate = Console.ReadLine().Split("-");
        DateOnly date = new DateOnly(int.Parse(fulldate[0]), int.Parse(fulldate[1]), int.Parse(fulldate[2]));
        v.CompleteVehicleSetup(lp, st, pol, date);
        
        // Use Odometer Reading as the first entry
        Console.WriteLine("--- input the current odometer reading---");
        Console.Write("mileage:  ");
        v.AddEntry(new InspectionEntry(
            v, DateOnly.FromDateTime(DateTime.Now), 0,
            int.Parse(Console.ReadLine())
        ));
    }
    
}