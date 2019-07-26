using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string result = String.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (ch >= 'a' && ch <= 'z')
            {
                int index = alphabet.IndexOf(ch) + shiftKey;
                index = index >= alphabet.Length ? index % alphabet.Length : index;
                ch = alphabet[index];
            }
            if ((ch >= 'A' && ch <= 'Z'))
            {
                int index = alphabet.ToUpper().IndexOf(ch) + shiftKey;
                index = index >= alphabet.Length ? index % alphabet.Length : index;
                ch = alphabet.ToUpper()[index];
            }
            result += ch.ToString();
        }
        return result;
    }
}