using System;
using System.Linq;

namespace Sklad
{
    internal class Program
    {
        static void Main()
        {
            string[] productName = null;
            long[] quantity = null;
            decimal[] prices = null;

            InputArray(out productName, out quantity, out prices);

            string input;
            do
            {
                Console.Write("Enter a product name (or 'done' to exit): ");
                input = Console.ReadLine();

                if (input == "done")
                {
                    break;
                }

                int index = Array.IndexOf(productName, input);
                if (index != -1)
                {
                    Console.WriteLine($"{productName[index]} costs: {prices[index]}; Available quantity: {quantity[index]}");
                }
                else
                {
                    Console.WriteLine("Product not in stock.");
                }
            } while (true);
        }

        private static void InputArray(out string[] pNames, out long[] pQuantity, out decimal[] pPrices)
        {
            pNames = Console.ReadLine().Split(' ').ToArray();
            pQuantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            pPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        }
    }
}
