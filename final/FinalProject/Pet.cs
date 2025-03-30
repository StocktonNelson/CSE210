public abstract class Pet
{
    string _Name;
    int _hunger;
    int _Energy;

    public Pet(string name)
    {
        _Name = name;
        _hunger = 5;
        _Energy = 5;
    }

    public virtual void MakeSound()
    {
        //* we dont need anything in here
    }
    //todo I want make each pet have a diffrent abount of time when be hungry 
    //*that and feed would have be harder to fill up or quick depending on the animale.
    public virtual void Sleep()
    {
        //* sleep bar would go up to 5 but lose 1 hunger;
        if (_Energy < 5)
        {
            _Energy++;
        }
        _hunger--;
    }

    public virtual void Feed()
    {
        //* bar would only go upto 5 bars.
        if (_hunger < 5)
        {
            _hunger++;
        }
        else
        {
            Console.WriteLine("This pet is full");
        }
    }

    public string getName()
    {
        return _Name;
    }

    public int getHunger()
    {
        return _hunger;
    }

    public void setHunger(int hunger)
    {
        if (hunger < 0)
        {
            _hunger = 0;
        }
        else if (hunger > 5)
        {
            _hunger = 5;
        }
        else
        {
            _hunger = hunger;
        }
    }

    public int getEnergy()
    {
        return _Energy;
    }

    public void setEnergy(int Energy)
    {
        if (Energy < 0)
        {
            _Energy = 0;
        }
        else if (Energy > 5)
        {
            _Energy = 5;
        }
        else
        {
            _Energy = Energy;
        }
    }
}