using System;

class Train : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Train is moving\n");
    }

    public void Turn()
    {
        Console.WriteLine("Train is turning");
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
