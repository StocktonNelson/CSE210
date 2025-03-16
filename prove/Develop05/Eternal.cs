public class Eternal : Goals
{
    public Eternal(string name, string description, int Goalpoints) : base(name, description, Goalpoints)
    {
    }

    public override void RecordEvent()
    {
        AddPoints();
    }
}
