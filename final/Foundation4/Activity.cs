public abstract class Activity
{
    private string _date;
    private int _length;
    private double _pace;
    private double _distance;
    private double _speed;

    public Activity(string date, int length){
        _date = date;
        _length = length;
    }

    public double GetSpeed(){
        return _speed;
    }
    public void setSpeed(double speed){
        _speed = speed;
    }
    public string GetDate(){
        return _date;
    }

    public double GetDistance(){
        return _distance;
    }

    public void SetDistance(double distance){
        _distance = distance; 
    }

    public double GetPace(){
        return _pace;
    }

    public void SetPace(double pace){
        _pace = pace;
    }

    public virtual void CalulateSpeed(){
        _speed = _distance / _length * 60;
    }

    public virtual void CalulatePace(){
        _pace = _length / _distance;
    }

    public virtual void CalulateDistance(){
        _distance = _length * _pace;
    }

    public int Getlength(){
        return _length;
    }
    
    public virtual string Getsummery(){
        return $"{_date} ";
    }
}