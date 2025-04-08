public class Omnivore : Mammal
{
    public override int Lifespan { get; set; } = 20;

    public void Forage()
    {
        Console.WriteLine("The omnivore is foraging");
    }
}
