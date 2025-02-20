public class WritingAssigment : Assignment
{
    private string _title;

    public WritingAssigment(string name, string topic, string title)
        : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation(){
        return $"{base.GetSummary()} - {_title}";
    }
}