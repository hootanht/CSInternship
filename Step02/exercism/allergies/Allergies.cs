using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}


public class Allergies
{
    public int Score { get; }
    public Allergies(int mask)
    {
        Score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (Score & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        List<Allergen> resultAllergen = new List<Allergen>();

        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                resultAllergen.Add(allergen);
            }
        }
        return resultAllergen.ToArray();
    }
}