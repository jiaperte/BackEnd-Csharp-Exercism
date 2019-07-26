using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> res = new Dictionary<char, int>();
        res.Add('A', 0);
        res.Add('C', 0);
        res.Add('G', 0);
        res.Add('T', 0);

        foreach (char ch in sequence)
        {
            try
            {
                res[ch]++;
            }
            catch (System.Exception)
            {
                throw new ArgumentException();
            }
        }
        return res;
        throw new NotImplementedException("You need to implement this function.");
    }
}