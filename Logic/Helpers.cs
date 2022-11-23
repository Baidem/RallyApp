using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Helpers
    {
        public static int GetIntFromConsole(string label, string error, Func<int, bool> isValid)
        {
            int number;
            Console.WriteLine(label);
            var input = Console.ReadLine();


            while (!int.TryParse(input, out number) || !isValid(number))
            {
                Console.WriteLine(error);
                Console.WriteLine(label);
                input = Console.ReadLine();
            }
            return number;
        }
        public static string GetStringFromConsole(string label, string error, Func<string, bool> isValid)
        {
            var input = "";
            while (input == "" || input == null || !isValid(input))
            {
                Console.WriteLine(label);
                input = Console.ReadLine();
                if (input != null && !isValid(input))
                    Console.WriteLine(error);
            }
            return input;
        }

    }
}
