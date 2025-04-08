public abstract class Mammal : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Some mammal sound");
    }
    public override abstract int Lifespan { get; set; }
}
