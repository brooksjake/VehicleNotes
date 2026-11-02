using System;
namespace csharp_prototype;

internal class Program
{
    static void Main(string[] args)
    {
        Driver driver = new Driver("Jesse", "Pinkman", new DateOnly(1998, 11, 4), "3148401451");
        driver.CreateNewVehicle();
        
    }
}