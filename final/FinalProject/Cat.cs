public class Cat : Pet
{
    string _FurColor;

    public Cat(string Name, string color) : base(Name)
    {
        _FurColor = color;
    }
    public override void MakeSound()
    {
        Console.Write("meow");
    }

    public override void Sleep()
    {
        //todo cat would lose two hunger every time they sleep.
        if (base.getEnergy() < 5)
        {
            base.setEnergy(base.getEnergy() - 1);
        }
        base.setHunger(base.getHunger() - 2);
    }

    public override void Feed()
    {
        //todo make cat fill to two hunger bars
        if (base.getHunger() < 5)
        {
            base.setHunger(getHunger() + 2);
        }
        else
        {
            Console.WriteLine("This pet is full");
        }
    }
}