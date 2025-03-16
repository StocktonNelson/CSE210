public class Basic : Goals
{
    public Basic(string name, string description, int Goalpoints) : base(name, description, Goalpoints)
    {
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        base.AddPoints();
    }
}
