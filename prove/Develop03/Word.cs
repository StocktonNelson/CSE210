public class Word
{
    private List<String> _text;
    private bool _isHidden;
    private Random _rand = new Random();

    public Word(string text)
    {
        this._text = text.Split().ToList();
        this._isHidden = false;
    }

    public void Hide()
    {
        // TODO: Hide the word

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


    public void Show() //! idk what this mean bu hope im using it right
    {
        // TODO: Show the word
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

