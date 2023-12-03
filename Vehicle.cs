using System;

abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }
    public int Density { get; set; }
    public string Name { get; set; }

    public virtual void LoadPassengers(int count)
    {
        Console.WriteLine($"Loading {count} passengers into {Name}");
    }

    public virtual void DisembarkPassengers(int count)
    {
        Console.WriteLine($"Disembarking {count} passengers from {Name}");
    }

    public abstract void Move();
}
