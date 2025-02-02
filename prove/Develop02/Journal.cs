public class Journal
{
    private List<Entry> entries = new List<Entry>(); // Initialize the list here

    public void AddEntry(string prompt, string response, DateTime date)
    {
        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        // TODO: Implementation
        Console.WriteLine("Entries:");
        for (int entry = 0; entry < entries.Count; entry++)
        {
            Console.WriteLine(entries[entry].ToString());
        }
    }

    //TODO I would do this later cause why do we need to add it to a file right now?
    public void SaveToFile(string filename)
    {
        // TODO: Implementation
        //* this should make a cvs file with a header if i did it correct or BLOW UP the computer
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Prompt,Response,Date");
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry._prompt},{entry._response},{entry._date:yyyy-MM-dd}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        // TODO: Implementatio
        //* This grabs all the cvs file data and put them into the entreis list 
        //*(Dont know new or add on top of exeisting stuff but to be safe we will remove all the stuff in it)
        //* good luck me

        entries.Clear(); //*clear list

        using (StreamReader reader = new StreamReader(filename))
        {
            string headerLine = reader.ReadLine(); //*Header and skips it
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }
    }

    //* Keeps the past entries and adds more
    public void LoadFromFileAndKeepEntries(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string headerLine = reader.ReadLine(); //*Header and skips it
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }
    }
}