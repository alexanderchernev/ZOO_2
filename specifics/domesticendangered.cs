public class DomesticEndangered : Carnivore, IEndangered, IDomestic
{
    public bool IsEndangered { get; set; } = true;

    public void DisplayStatus()
    {
        Console.WriteLine(IsEndangered ? "This animal is endangered." : "This animal is not endangered.");
    }

    public void Feed()
    {
        Console.WriteLine("Feeding the domestic animal.");
    }

    public void Play()
    {
        Console.WriteLine("Playing with the domestic animal.");
    }
}
