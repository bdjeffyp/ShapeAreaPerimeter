using System;

namespace ShapeAreaPerimeter
{
    class Program
    {
        /***************************************
         * ShapeAreaPerimeter
         * Developer: Jeff Peterson
         * Date: 06/19/2017
         * Purpose: Find the area and perimeter of a variety of shapes.
         ***************************************/
        static void Main(string[] args)
        {
            // Variables
            int option;                     // Selects the shape to work with.
            const int square = 1;
            const int circle = 2;

            //TODO: Work on making other shapes later. For now, let's do a circle and rectangle.
            Console.WriteLine("Find the area and perimeter of shapes");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nSelect from the following shapes:");
            Console.WriteLine("1) Rectangle/Square");
            Console.WriteLine("2) Circle");
            Console.WriteLine("More shapes to come...");

            // Get the option the user wants.
            while (true)
            {
                Console.Write("Which shape? ");
                option = int.Parse(Console.ReadLine());
                // Make sure we get a valid input from the user.
                if (option != 1 && option != 2)
                {
                    // Try again if the user gave a bad entry.
                    Console.WriteLine("\nThat is not a valid option.  Try again.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("");
            // Peform work on the selected shape.
            switch (option)
            {
                case square:
                    float width, height;
                    Console.WriteLine("Rectangle/Square");
                    Console.Write("Width: ");
                    width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    height = float.Parse(Console.ReadLine());
                    Console.WriteLine("The perimeter is {0}", rectPerimeter(width, height));
                    Console.WriteLine("The area is {0}", rectArea(width, height));
                    break;

                case circle:
                    float radius;
                    Console.WriteLine("Circle");
                    Console.Write("Radius: ");
                    radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("The circumference is {0}", circlePerimeter(radius));
                    Console.WriteLine("The area is {0}", circleArea(radius));
                    break;

                default:
                    Console.WriteLine("Well... That wasn't supposed to happen!");
                    break;
            }
        }

        //TODO: Should make classes for the shapes.
        // Calculate the perimeter of a square or rectangle
        static float rectPerimeter(float width, float height)
        {
            return (width * 2) + (height * 2);
        }

        // Calculate the area of a square or rectangle
        static float rectArea(float width, float height)
        {
            return width * height;
        }

        // Calculate the perimeter (circumference) of a circle
        static float circlePerimeter(float radius)
        {
            return (float)(2 * Math.PI * radius);
        }

        // Calculate the area of a circle
        static float circleArea(float radius)
        {
            return (float)(Math.PI * radius * radius);
        }
    }
}
