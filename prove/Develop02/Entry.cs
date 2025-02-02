public class Entry
{
    // Properties
    public string _prompt; 
    public string _response;
    // Date of today is defult.
    public DateTime _date = DateTime.Today;

    public Entry(string prompt, string response, DateTime date)
    {
        // TODO: Implementation a way to defult the date to today
        this._prompt = prompt;
        this._response = response;
        this._date = date;
    }

    public string ToString()
    {
        return "Prompt: " + _prompt + "\n Response: " + _response + "\nDate: " + _date;
    }
}
