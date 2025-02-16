
public class Reference {
    private String _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    public Reference(String book, int chapter, int verse) {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;

    }

    public Reference(String book, int chapter, int startVerse, int endVerse) {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    public String GetFormattedReference() {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}";
    }
}