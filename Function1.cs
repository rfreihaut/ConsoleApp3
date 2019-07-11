using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            double l, w, h, perimeter, area, volume;

            Console.WriteLine("perimeter area and voulme measuremnts");
            Console.WriteLine("Enter length ");
            l = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width ");
            w = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height ");
            h = double.Parse(Console.ReadLine());

            perimeter = 2 * l + 2 * w;
            area = l * w;
            volume = l * w * h;

            Console.WriteLine("perimeter in feet is {0}", perimeter);
            Console.WriteLine("area in square feet is {0}", area);
            Console.WriteLine("volume in cubic feet is {0}", volume);

        }
    }
}