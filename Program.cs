using System;

namespace Lab2Version2Calculate_AreaWidthVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Y";
            decimal length;
            decimal height;
            decimal width;



            while (input != "N")

            {


                Console.WriteLine("Enter the width");
                var widthAsString = Console.ReadLine();

                if (decimal.TryParse(widthAsString, out width))
                    Console.WriteLine($"The width is: {width}");
                else
                    Console.WriteLine("This is not a number!");


                Console.WriteLine("Input the length");
                var lengthAsString = Console.ReadLine();

                if (decimal.TryParse(lengthAsString, out length))
                    Console.WriteLine($"The length is: {length}");
                else
                    Console.WriteLine("This is not a number!");

                Console.WriteLine("Input the height");
                var heightAsString = Console.ReadLine();

                if (decimal.TryParse(heightAsString, out height))
                    Console.WriteLine($"Your age is: {height}");
                else
                    Console.WriteLine("This is not a number!");


                decimal area = width * length;
                decimal perimeter = (width + length) * 2;
                decimal volume = width * length * height;


                Console.WriteLine("The Perimeter is " + " " + perimeter);
                Console.WriteLine("The Area is " + " " + area);
                Console.WriteLine("The Volume is " + " " + volume);


                Console.WriteLine("Do you want to continue? Y/N");
                input = Console.ReadLine();

            }
        }
    }

}