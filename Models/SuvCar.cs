using BlazorApp.Models.Enums;

namespace BlazorApp.Models;

public class SuvCar : Vehicle
{
    public string Category { get; set; } = VehicleCategory.Suv.ToString();
    
    public bool IsFourWheelDrive { get; set; } = false;
    public int GroundClearance { get; set; } = 0;
}