using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_dimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Requirements:
            /// - Floor area
            /// - Amount of paint to paint WALLS - average coverage is 10m²/l [www.diy.com/help-advice/wall-painting-calculator/Dev_npcart_100008.art]
            /// - Volume of room

            // Define variables
            float l = 0; // Length
            float w = 0; // Width
            float h = 0; // Height
            Boolean isNum = false;

            while (isNum == false)
            {
                Console.Clear();
                Console.WriteLine("~ Input dimensions in metres ~");
                Console.Write("Length: ");
                string length = Console.ReadLine();
                Console.Write("Width: ");
                string width = Console.ReadLine();
                Console.Write("Height: ");
                string height = Console.ReadLine();

                try
                {
                    l = float.Parse(length);
                    w = float.Parse(width);
                    h = float.Parse(height);
                    if ((l > 0) & (h > 0) & (h > 0)) // Checks if all values are positive
                    {
                        isNum = true;
                    }
                    else
                    {
                        Console.WriteLine("Positive values only");
                        Console.ReadKey();
                    }
                }

                catch
                {
                    Console.WriteLine("Please enter numerical values");
                    Console.ReadKey();
                };
      
            } // When all values are numbers:
            Console.WriteLine("======================="); 
            // Floor area
            float floorArea = (l * w);
            Console.Write("Floor area is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(floorArea);
            Console.ResetColor();
            Console.WriteLine(" m²");

            // Amount of paint
            // Only walls being painted
            // Surface area = 2h (l + w)

            float surfaceArea = (2 * h) * (l + w);
            float paintNeeded = surfaceArea / 10;
            Console.Write("Total wall area is ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(surfaceArea);
            Console.ResetColor();
            Console.WriteLine(" m²");
            Console.Write("Therefore, amount of paint needed is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(paintNeeded);
            Console.ResetColor();
            Console.WriteLine(" litres");

            // Volume of room
            float roomVolume = l * w * h;
            Console.Write("Room volume is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(roomVolume);
            Console.ResetColor();
            Console.WriteLine(" m³");
            Console.ReadKey();
        }
    }
}
