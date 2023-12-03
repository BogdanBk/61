using System;

class Human : Vehicle
{
    public void Walk()
    {
        Console.WriteLine("Human is just walking and doesn't care what's going on on the road, " +
                          "it is good to be human\n");
    }

    public override void Move()
    {
        Walk();
    }
}
