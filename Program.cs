using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Enter a number to add to the total, then press enter.");
            Console.WriteLine("Press C to reset the total.");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                else if (input == "C")
                {
                    Console.WriteLine("Total reset.");
                    total = 0;
                    continue;
                }
                else
                {
                    double value = 0;
                    try
                    {
                        value = Convert.ToDouble(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Non-numeric value entered.");
                        continue;
                    }

                    total += value;

                    Console.WriteLine("Total: {0}", Convert.ToString(total));
                }
            }

            Console.WriteLine("End total: {0}", Convert.ToString(total));
            Console.WriteLine("Press enter to close.");
            Console.ReadLine();
        }
    }
}
