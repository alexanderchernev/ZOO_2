public class WildEndangered : Herbivore, IEndangered, IWild
{
    public bool IsEndangered { get; set; } = true;

    public void DisplayStatus()
    {
        Console.WriteLine(IsEndangered ? "This animal is endangered." : "This animal is not endangered.");
    }

    public void Roam()
    {
        Console.WriteLine("The wild animal is roaming in the wild.");
    }
}