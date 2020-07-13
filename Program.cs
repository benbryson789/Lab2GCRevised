using System;

namespace Lab2Version2Calculate_AreaWidthVolume
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = "Y";
            decimal length = 0;
            decimal height = 0;
            decimal width = 0;



            while (input.ToLower() != "n")

            {

                bool widthIsValid = false;
                bool lengthIsValid = false;
                bool heightIsValid = false;

                // width
                while (!widthIsValid)
                {
                    Console.WriteLine("Enter the width");
                    var widthAsString = Console.ReadLine();

                    if (decimal.TryParse(widthAsString, out width))
                    {
                        Console.WriteLine($"The width is: {width}");
                        widthIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a number!");
                        widthIsValid = false;
                    }
                }


                // length
                while (!lengthIsValid)
                {
                    Console.WriteLine("Input the length");
                    var lengthAsString = Console.ReadLine();

                    if (decimal.TryParse(lengthAsString, out length))
                    {
                        Console.WriteLine($"The length is: {length}");
                        lengthIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a number!");
                        lengthIsValid = false;
                    }
                }


                // height
                while (!heightIsValid)
                {
                    Console.WriteLine("Input the height");
                    var heightAsString = Console.ReadLine();

                    if (decimal.TryParse(heightAsString, out height))
                    {
                        Console.WriteLine($"Your height is: {height}");
                        heightIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("This is not a number!");
                        heightIsValid = false;
                    }
                }


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