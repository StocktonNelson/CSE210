public class Lectuer : Event
{
    private string _speaker;

    private int _AmountOfGuest;

    public Lectuer(string title, string description, string date, string time, string address, string speaker, int amountOfGuest) : base(title, description, date, time, address){
        _speaker = speaker;
        _AmountOfGuest = amountOfGuest;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetAmountOfGuest()
    {
        return _AmountOfGuest;
    }

    public override void GetStanderedInfo(){
        Console.WriteLine($"Title: {base.GetTitle()} \nDescription: {base.GetDescription()} \nDate: {base.GetDate()} \nTime: {base.GetTime()} \nAddress: {base.GetAddress()}");
    }

    public override void GetLongInfo(){
        Console.WriteLine($"Title: {base.GetTitle()} \nDescription: {base.GetDescription()} \nDate: {base.GetDate()} \nTime: {base.GetTime()} \nAddress: {base.GetAddress()} \nEvent: Lectuer \nSpeaker: {_speaker} \nAmount of Guests: {_AmountOfGuest}");
    }

    public override void GetShortInfo(){
        Console.WriteLine($"Event: Lectuer \nTitle: {base.GetTitle()} \nDate: {base.GetDate()}");
    }
}