using System;
using System.Linq;

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
    private int _allergies;
    public Allergies(int mask)
    {
        _allergies = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return ((int)allergen & _allergies) > 0;
        throw new NotImplementedException("You need to implement this function.");
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
                .Cast<Allergen>()
                .Where(x => ((int)x & _allergies) > 0)
                .ToArray();
        throw new NotImplementedException("You need to implement this function.");
    }
}