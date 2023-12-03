using System;
using System.Collections.Generic;
using System.Linq;

class TransportNetwork
{
    private readonly Random random = new Random();
    private readonly List<(Vehicle vehicle, int passengers)> vehicles = new List<(Vehicle, int)>();

    private int CarsPassengers { get; set; }
    private int BusesPassengers { get; set; }
    private int TrainsPassengers { get; set; }
    private int CarsAmount { get; set; }
    private int BusesAmount { get; set; }
    private int TrainsAmount { get; set; }

    public void AddVehicle(Vehicle vehicle, int passengers)
    {
        vehicles.Add((vehicle, passengers));
        SettingVehiclesAndPassengers();
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        var vehicleToRemove = vehicles.FirstOrDefault(x => x.vehicle == vehicle);
        if (vehicleToRemove.vehicle != null)
        {
            vehicles.Remove(vehicleToRemove);
            SettingVehiclesAndPassengers();
        }
    }

    private void SettingVehiclesAndPassengers()
    {
        CarsAmount = 0;
        CarsPassengers = 0;
        BusesAmount = 0;
        BusesPassengers = 0;
        TrainsAmount = 0;
        TrainsPassengers = 0;

        foreach ((Vehicle vehicle, int passengers) in vehicles)
        {
            if (vehicle is Car)
            {
                ++CarsAmount;
                CarsPassengers += passengers;
                vehicle.LoadPassengers(passengers);
                int passengersToDisembark = random.Next(1, passengers + 1);
                vehicle.DisembarkPassengers(passengersToDisembark);
            }
            else if (vehicle is Bus)
            {
                ++BusesAmount;
                BusesPassengers += passengers;
                vehicle.LoadPassengers(passengers);
                int passengersToDisembark = random.Next(1, passengers + 1);
                vehicle.DisembarkPassengers(passengersToDisembark);
            }
            else if (vehicle is Train)
            {
                ++TrainsAmount;
                TrainsPassengers += passengers;
                vehicle.LoadPassengers(passengers);
                int passengersToDisembark = random.Next(1, passengers + 1);
                vehicle.DisembarkPassengers(passengersToDisembark);
            }
        }
    }

    public void AmountOfVehicles()
    {
        Console.WriteLine($"\nThere are currently {vehicles.Count} vehicles.\n" +
                          $"Cars: {CarsAmount}, with {CarsPassengers} people in them\n" +
                          $"Buses: {BusesAmount}, with {BusesPassengers} people in them\n" +
                          $"Trains: {TrainsAmount}, with {TrainsPassengers} people in them\n");
    }
}
