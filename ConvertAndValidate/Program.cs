/* Ashton Tolman
 * Spring 2026
 * ConvertAndValidate
 * https://github.com/Ashton-Tolman/ConvertAndValidate.git
 */
using System.Linq.Expressions;

namespace ConvertAndValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine(ConvertAndValidate(ref total, ""));
            

            //pause
            Console.Read();
        }
        static bool ConvertAndValidate(ref int total, string userInput)
        {
            bool isNumber;
            
            do
            {
                try
                {
                    Console.WriteLine("Check for a number:");
                    userInput = Console.ReadLine();
                    int.Parse(userInput);
                    Console.WriteLine("Correct conversion");
                    isNumber = true;
                    total += int.Parse(userInput);
                }
                catch (Exception)
                {
                    if (userInput is not "q" and not "Q")
                    {
                        Console.WriteLine("Converstion failed");
                        isNumber = false;
                        total = total;
                    }
                    else
                    {
                        isNumber = false;
                        total = total;
                        Console.WriteLine("Goodbye");
                    }
                }
            } while (userInput is not "q" and not "Q");
            Console.WriteLine($"The total of your numbers is: {total}");
            Console.WriteLine("last conversion status:");
            return isNumber;
        }
    }
}
