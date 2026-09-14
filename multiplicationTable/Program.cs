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

            int number1 = 7;
            int number2 = 7;

            bool isValid = false;

            int result = 0;
            string output = "";

            Console.WriteLine("Welcome, please enter the length of the table");
            userInput1 = Console.ReadLine();
            if (isValid == false)
            {
                Console.WriteLine("Please enter a valid number");
                userInput1 = Console.ReadLine();
            }
            number1 = int.Parse(userInput1);
            Console.WriteLine("Welcome, please enter the width of the table");
            userInput2 = Console.ReadLine();
            number2 = int.Parse(userInput2);

            for (int i = 0; i < number1; i++)
            {
                for (int j = 0; j < number2; j++)
                {
                    result = i + j;
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
