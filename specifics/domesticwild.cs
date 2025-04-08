public class DomesticWild : Omnivore, IDomestic, IWild
{
    public void Feed()
    {
        Console.WriteLine("Feeding the domestic wild animal.");
    }

    public void Play()
    {
        Console.WriteLine("Playing with the domestic wild animal.");
    }

    public void Roam()
    {
        Console.WriteLine("The domestic wild animal is roaming.");
    }
}