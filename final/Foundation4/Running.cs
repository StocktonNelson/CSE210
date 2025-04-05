public class Running : Activity
{
    public Running(string date, int length, double distance) : base(date, length){
        base.SetDistance(distance);
    }

    public override void CalulateSpeed()
    {
        base.CalulateSpeed();
    }

    public override void CalulatePace()
    {
        base.CalulatePace();
    }

    public override string Getsummery()
    {
        CalulateSpeed();
        CalulatePace();
        return base.Getsummery() + $"Running ({base.Getlength()}) - Distance {base.GetDistance()} km, Speed {base.GetSpeed()} kph, Pace: {base.GetPace()} min per km";
    }
}