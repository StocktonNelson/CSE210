public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int length, int laps) : base(date, length){
        _laps = laps;
    }

    public override void CalulateDistance()
    {
        base.SetDistance(_laps * 50 / 1000);
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
        CalulateDistance();
        CalulateSpeed();
        CalulatePace();
        return base.Getsummery() + $"Swimming ({_laps}) - Distance {base.GetDistance()} km, Speed {base.GetSpeed()} kph, Pace: {base.GetPace()} min per km";
    }
}