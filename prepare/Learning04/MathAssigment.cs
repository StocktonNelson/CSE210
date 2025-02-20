public class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string name, string topic, string textbook, string problems)
        : base(name, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"{base.GetSummary()} - Section {_textbookSection} Problems {_problems}";
    }
}