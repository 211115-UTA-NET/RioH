using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        protected double RectangleArea(int length, int width) 
{
    get
    return this.RectangleArea
}
set 
{
if
Length = “+(length)
Width = “+(width)
width * length
}
    }
        
        
        // Implement your Rectangle class here.
        public Rectangle(string name, int numSides) : base()
        {
            Name = name;
            NumSides = numSides;
            Console.WriteLine(name, numSides);
    }
}
