public class Video
{
    string _AccountName;
    string _Title;
    int _VideoLength;

    List<Comment> _comments = new List<Comment>();

    public Video(string name, string title, int length, List<Comment> comments){
        _AccountName = name;
        _Title = title;
        _VideoLength = length;
        _comments = comments;
    }

    public void GetVideoInfo(){
        Console.WriteLine($"Account: {_AccountName} \nVideo Title: {_Title} \nVideo Length (seconds): {_VideoLength} \nComments:");
        foreach(Comment comment in _comments){
            Console.WriteLine(comment.getComment());
        }
    }
}