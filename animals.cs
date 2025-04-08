public abstract class Animal
{
    public string Name { get; set; }
    public string Habitat { get; set; }
    public abstract void MakeSound();
    public abstract int Lifespan { get; set; }
}
