using System.Globalization;

public class Bird : Pet
{
    string _Breed;

    public Bird(string Name, string breed) : base(Name)
    {
        _Breed = breed;
    }
    public override void MakeSound()
    {
        Console.Write("chip");
    }

    public override void Sleep()
    {
        //todo birld would lose one hunger very time they sleep.
        base.Sleep();
    }

    public override void Feed()
    {
        //todo make bird fill to full hunger
        if (base.getHunger() < 5)
        {
            base.setHunger(getHunger() + 5);
        }
        else
        {
            Console.WriteLine("This pet is full");
        }
    }
}