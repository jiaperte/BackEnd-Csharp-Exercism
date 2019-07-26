using System;
using System.Runtime.Serialization;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new InvalidStringLengthException();
        }
        int distance = 0;
        foreach (var ch2 in secondStrand)
        {
            foreach (var ch1 in firstStrand)
            {
                if (ch1 == ch2)
                {
                    distance++;
                }
            }
        }
        return distance;
        throw new NotImplementedException("You need to implement this function.");
    }

    [Serializable]
    private class InvalidStringLengthException : Exception
    {
        public InvalidStringLengthException()
        {
        }

        public InvalidStringLengthException(string message) : base(message)
        {
        }

        public InvalidStringLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidStringLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}