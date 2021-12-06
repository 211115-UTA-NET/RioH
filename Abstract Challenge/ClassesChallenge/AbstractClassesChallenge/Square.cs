using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
          public Square(string name, int numSides) : base(name, numSides)
        {
            Name = name;
            NumSides = numSides;
            Console.WriteLine(name, numSides);
    }
    }
}
