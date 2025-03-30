public class Comment
{
    string _AccountName;
    string _Text;

    public Comment(string name, string text){
        _AccountName = name;
        _Text = text;
    }

    public string getComment(){
        return $"{_AccountName}: {_Text}";
    }
}