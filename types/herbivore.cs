public class Herbivore : Mammal
{
    public override int Lifespan { get; set; } = 25;

    public void Graze()
    {
        Console.WriteLine("The herbivore is grazing");
    }
}
