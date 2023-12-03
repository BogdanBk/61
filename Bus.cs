using System;

class Bus : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Bus is moving\n");
    }

    public void Turn()
    {
        Console.WriteLine("Bus is turning");
    }

    public override void LoadPassengers(int count)
    {
        base.LoadPassengers(count);
    }

    public override void DisembarkPassengers(int count)
    {
        base.DisembarkPassengers(count);
    }

    public override void Move()
    {
        Drive();
    }
}
