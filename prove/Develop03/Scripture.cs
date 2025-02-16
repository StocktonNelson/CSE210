public class Scripture {
    private Reference _reference;
    private Word _words;
    

    public Scripture(Reference reference, String text) {
        _reference = reference;
        _words = new Word(text);
    }

    public void Show() {
        _words.Show();
    }
    
    public void HideWords() {
        _words.Hide();
    }

    public String GetRenderedText() {
        return _words.GetRenderedText();
    }

    public Boolean IsCompletelyHidden() {
        return _words.IsHidden();
    }
}