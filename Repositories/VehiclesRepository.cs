using BlazorApp.Models;

namespace BlazorApp.Repositories;

public static class VehiclesRepository
{
    public static List<Vehicle> GetVehicles()
    {
        return vehiclesList;
    }
    
    public static void AddVehicle(Vehicle vehicle)
    {
        vehiclesList.Add(vehicle);
    }
    
    public static void UpdateVehicle(Vehicle vehicle)
    {
        var index = vehiclesList.FindIndex(v => v.Id == vehicle.Id);
        vehiclesList[index] = vehicle;
    }
    

    public static void DeleteVehicle(Vehicle vehicle)
    {
        vehiclesList.Remove(vehicle);
    }
    
    private static List<Vehicle> vehiclesList = new();
}