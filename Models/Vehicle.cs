using BlazorApp.Models.Enums;

namespace BlazorApp.Models;

public abstract class Vehicle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public string Category { get; set; } = VehicleCategory.Economy.ToString();
    public string Colour { get; set; } = "";
    public string Vin { get; set; } = "";
    public int Mileage { get; set; } = 0;
    public VehicleStatus Status { get; set; } = VehicleStatus.Available;
}