public class Carnivore : Mammal
{
    public override int Lifespan { get; set; } = 15;

    public void Hunt()
    {
        Console.WriteLine("The carnivore is hunting");
    }
}
