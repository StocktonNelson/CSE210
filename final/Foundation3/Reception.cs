public class Reception : Event
{
    private List<string> _register;

    public Reception(string title, string description, string date, string time, string address, List<string> registers) : base(title, description, date, time, address){
        _register = registers;
    }

    public List<string> GetRegisters(){
        return _register;
    }

    public override void GetStanderedInfo(){
        base.GetStanderedInfo();
    }

    public override void GetLongInfo(){
        Console.WriteLine($"Title: {base.GetTitle()} \nDescription: {base.GetDescription()} \nDate: {base.GetDate()} \nTime: {base.GetTime()} \nAddress: {base.GetAddress()} \nEvent: Reception");
        Console.WriteLine("List of RVSP");
        foreach (string Email in _register){
            Console.WriteLine(Email);
        }
    }

    public override void GetShortInfo(){
        Console.WriteLine($"Event: Outdoor \nTitle: {base.GetTitle()} \nDate: {base.GetDate()}");
    }
}