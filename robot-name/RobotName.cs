using System;
using System.Collections.Generic;

public class Robot
{
    public static List<string> NameInUse = new List<string>();
    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string _Name;
    public Robot()
    {
        _Name = GenerateNewName();
    }
    public string Name
    {
        get
        {
            return _Name;
            throw new NotImplementedException("You need to implement this function.");
        }
    }

    public void Reset()
    {
        NameInUse.Remove(_Name);
        _Name = GenerateNewName();
        //throw new NotImplementedException("You need to implement this function.");
    }

    public string GenerateNewName()
    {
        Random rand = new Random();
        string tmp = alphabet[rand.Next(0, 25)].ToString() +
                    alphabet[rand.Next(0, 25)].ToString() +
                    rand.Next(0, 9).ToString() +
                    rand.Next(0, 9).ToString() +
                    rand.Next(0, 9).ToString();

        if (NameInUse.Contains(tmp))
        {
            tmp = GenerateNewName();
        }
        NameInUse.Add(tmp);
        return tmp;
    }
}