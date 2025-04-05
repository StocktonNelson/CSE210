public class Cycling : Activity
{
    public Cycling(string date, int length, double speed) : base(date, length){
        base.setSpeed(speed);
    }

    public override void CalulateDistance()
    {
        base.CalulateDistance();
    }

    public override void CalulatePace()
    {
        base.CalulatePace();
    }

    public override string Getsummery()
    {
        CalulateDistance();
        CalulatePace();
        return base.Getsummery() + $"Cycling ({base.Getlength()}) - Distance {base.GetDistance()} km, Speed {base.GetSpeed()} kph, Pace: {base.GetPace()} min per km";
    }
}