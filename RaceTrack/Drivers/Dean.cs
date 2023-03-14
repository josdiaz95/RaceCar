using System;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers;

public class Dean : Driver
{
    public Dean(RaceCar car) : base(car)
    {
        Name = "Dean Winchester";
        SkillLevel = 10;
    }

    public override void Drive()
    {
        Car.Accelerate(SkillLevel);
    }
}