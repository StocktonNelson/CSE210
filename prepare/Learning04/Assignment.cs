public class Assignment
{
    private string _studnetName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studnetName = studentName;
        _topic = topic;
    }
    
    public string GetSummary(){
        return $"{_studnetName} - {_topic}";
    }
}