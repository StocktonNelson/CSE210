class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Event lectuer = new Lectuer("Ted talk", "a speech about why java is better then c#", "6月 29日 2026年", "9pm", "525 S Center St Rexburg, ID 83460", "Stockton S. Nelson", 220);
        Event outdoor = new Outdoor("Anti-Arson", "An outdoor event to spread awareness of wild fire", "29 de junio de 2026", "21:00", "-77.87445298630027, -34.63252714246088", "A bit chilly weather with 1% of snow");
        Event Reception = new Reception("Wedding", "I think someone is getting married but don't know", "29 Juni 2026", "00:00", "-53.09904765395786, 73.48369330340786", new List<string> { "byui@byui.com", "urMom@yahoo.com", "qwertyuiopasdfghjklzxcvbnm@wiki.org" });

        events.Add(lectuer);
        events.Add(outdoor);
        events.Add(Reception);

        //* event is a keyword so i added "_"
        foreach(Event _event in events){
            Console.WriteLine("-----------------short------------");
            _event.GetShortInfo();
            Console.WriteLine("---------------standerd-------------");
            _event.GetStanderedInfo();
            Console.WriteLine("--------------------long----------------");
            _event.GetLongInfo();
        }
    }
}