public class Word
{
    private List<String> _text;
    private bool _isHidden;
    private Random _rand = new Random();

    private List<String> _OgText; //* added for show() function

    public Word(string text)
    {
        this._text = text.Split().ToList();
        this._isHidden = false;
        this._OgText = text.Split().ToList();
    }

    public void Hide()
    {
        if (!IsHidden())
        {
            // grabs the word
            int index;
            //prevent blank words being seleced again
            //! IF I GET A ANOTHER INFINTE LOOP! IM DESTROY THIS COMPUTER
            while (true)
            {
                index = _rand.Next(_text.Count);
                //
                if (_text.All(word => word.Contains("_")))//* check the whole list has "_"
                {
                    _isHidden = true;
                    break;
                }
                else if (_text[index].Contains("_"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            string word = _text[index];

            //makes hidden word replacemnt
            int length = word.Length;
            string hiddenWord = new string('_', length);
            _text[index] = hiddenWord;

        }
    }


    public void Show() //* some but but mostly works
    {
        _text = new List<string>(_OgText); // just us og text to take back to it origianl text.
        _isHidden = false;
        Console.WriteLine(GetRenderedText());
    }

    public bool IsHidden()
    {
        // TODO: Check if word is hidden
        return _isHidden;
    }

    public string GetRenderedText()
    {
        // TODO: Return rendered text based on hidden state
        return string.Join(" ", _text);
    }

}

