using System;
using System.Collections.Generic;

public class Zoo
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Carnivore() { Name = "Lion", Habitat = "Savannah" },
            new Herbivore() { Name = "Elephant", Habitat = "Forest" },
            new Omnivore() { Name = "Bear", Habitat = "Forest" }
        };
        foreach (var animal in animals)
        {
            Console.WriteLine($"Animal: {animal.Name}");
            animal.MakeSound();
            Console.WriteLine($"Habitat: {animal.Habitat}");
            Console.WriteLine($"Lifespan: {animal.Lifespan} years\n");
        }

        List<IEndangered> endangeredAnimals = new List<IEndangered>
        {
            new DomesticEndangered() { Name = "Panda", IsEndangered = true },
            new WildEndangered() { Name = "Tiger", IsEndangered = true }
        };
        foreach (var endangered in endangeredAnimals)
        {
            endangered.DisplayStatus();
        }

        List<IDomestic> domesticAnimals = new List<IDomestic>
        {
            new DomesticEndangered() { Name = "Dog" },
            new DomesticWild() { Name = "Wild Dog" }
        };
        foreach (var domestic in domesticAnimals)
        {
            domestic.Feed();
            domestic.Play();
        }

        List<IWild> wildAnimals = new List<IWild>
        {
            new WildEndangered() { Name = "Lion" },
            new DomesticWild() { Name = "Wild Bear" }
        };
        foreach (var wild in wildAnimals)
        {
            wild.Roam();
        }
    }
}
