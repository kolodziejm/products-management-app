using BlazorApp.Models.Enums;

namespace BlazorApp.Models;

public sealed class SportsCar : Vehicle
{
    public string Category { get; set; } = VehicleCategory.Sports.ToString();
    
    public float Acceleration { get; set; } = 0;
    public int TopSpeed { get; set; } = 0;
    public int Horsepower { get; set; } = 0;
}