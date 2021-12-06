using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
          public Triangle(string name, int numSides) : base(name, numSides)
        {
            Name = name;
            NumSides = numSides;
            Console.WriteLine(name, numSides);
    }
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
    }
}
