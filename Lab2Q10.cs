using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    // Base class 'Shape'
    class Shape
    {
        // Properties for Length and Breadth
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parametrized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class 'Rectangle' from 'Shape'
    class Rectangle : Shape
    {
        // Constructor to initialize Length and Breadth in the base class
        public Rectangle(double length, double breadth) : base(length, breadth) { }

        // Method to calculate area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    // Test program
    class Lab2Q10
    {
        /*static void Main(string[] args)
        {
            // Creating an object of Rectangle class with given length and breadth
            Rectangle rectangle = new Rectangle(5.0, 3.0);

            // Calculating and displaying the area
            Console.WriteLine("Area of the rectangle: " + rectangle.CalculateArea());
        }*/
    }

}
