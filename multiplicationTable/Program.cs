//Jonathan Paul
//RCET2265
//Fall 2026
//https://github.com/jmpaul484/multiplicationTable.git
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
            // This while loop will continue to prompt the user for input until a valid number is entered for the first number
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
            // This while loop will continue to prompt the user for input until a valid number is entered for the second number
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
            // This line clears the console so that the output is easier to read
            Console.Clear();
            // This line prints the multiplication table based on the user input
            Console.WriteLine($" Your requested multiplication Table {number1} x {number2}");
            // This line prints the top row or length of the multiplication table
            for (int i = 1; i <= number1; i++)
            {
                // This line prints the left column or width of the multiplication table
                for (int j = 1; j <= number2; j++)
                {
                    result = i * j;
                    output = $"{result} |";
                    output = output.PadLeft(6);
                    Console.Write(output);
                }
                Console.WriteLine();
            }
            //pause the console so that the user can see the output before the program ends
            Console.ReadLine();
        }
    }
}
