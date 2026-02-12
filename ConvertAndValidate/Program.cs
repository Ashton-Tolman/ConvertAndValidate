/* Ashton Tolman
 * Spring 2026
 * ConvertAndValidate
 * https://github.com/Ashton-Tolman/ConvertAndValidate.git
 */
namespace ConvertAndValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool result = false;
            ConvertAndValidate(out userInput,result);
            

            //pause
            Console.Read();
        }

        static bool ConvertAndValidate(out string userInputA, bool resultA)
        {
            bool result = false;
            string userInput = "";
            try
            {
                int.Parse(userInput);
                
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
