public class Dog : Pet
{
    string _Breed;


    public Dog(string Name, string breed) : base(Name)
    {
        _Breed = breed;
    }
    public override void MakeSound()
    {
        Console.Write("woof");
    }

    public override void Sleep()
    {
        //todo cat would lose two hunger very time they sleep.
        if (base.getEnergy() < 5)
        {
            base.setEnergy(base.getEnergy() - 1);
        }
        base.setHunger(base.getHunger() - 2);
    }

    public override void Feed()
    {
        //todo make cat fill to one hunger bar
        base.Feed();
    }
}