using System;

namespace RaceTrack.RaceTrack.Cars;

public class ChevyImpala : RaceCar
{
    public ChevyImpala()
    {
        Name = "Chevy Impala";
        TopSpeed = 160;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"The {Name} sounds like a monster!"); ;
    }

    public override void Brake()
    {
        Console.WriteLine($"The {Name} goes so fast that it screeches when it brakes.");
        base.Brake();
    }
}