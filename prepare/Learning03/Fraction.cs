class Fraction
{
    private int _top;

    private int _bottom;


    public Fraction(){

        _top = 1;

        _bottom = 1;
    }

    public Fraction(int _top){

        this._top = _top;

        _bottom = 1;
    }

    public Fraction(int _top, int _bottom){

        this._top = _top;

        this._bottom = _bottom;
    }

    public int GetTop(){
        return _top;
    }

    public void SetTop(int _top){
        this._top = _top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int _bottom){
        this._bottom = _bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

        public double GetDecimalValue (){
        double math = (double)_top / (double)_bottom;
        return math;
    }
}