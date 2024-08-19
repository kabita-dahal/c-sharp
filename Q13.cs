using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabitaLabwork
{
    internal class Q13
    {
        static void Main()
        {
            // Define a string array
            string[] words = { "Hi", "I", "am", "Kabita." };

            // Convert the string array to a single string
            string result = string.Join(" ", words);

            // Output the result
            Console.WriteLine("The concatenated string is:");
            Console.WriteLine(result);
        }
    }
}
