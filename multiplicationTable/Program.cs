//Jonathan Paul
//RCET2265
//Fall 2026
//
namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInput1 = "";
            String userInput2 = "";

            int number1 = 12;
            int number2 = 12;

            bool isValid = false;

            int result = 0;
            string output = "";

            while (isValid == false)
            {
            Console.WriteLine("Welcome, please enter the length of the table");
            userInput1 = Console.ReadLine();
                try
                {
                number1 = int.Parse(userInput1);
                isValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                    isValid = false;
                }
            }

            isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Welcome, please enter the width of the table");
                userInput2 = Console.ReadLine();
                try
                {
                    number2 = int.Parse(userInput2);
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                    isValid = false;
                }
            }

            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= number2; j++)
                {
                    result = i * j;
                    output = $"{result} |";
                    output = output.PadLeft(5);
                    Console.Write(output);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
