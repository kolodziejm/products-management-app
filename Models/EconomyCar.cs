namespace BlazorApp.Models;

public sealed class EconomyCar : Vehicle
{
    public float FuelEfficiency { get; set; } = 0;
    public int TrunkSpace { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 0;
}