
namespace Assignment2_1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user's name
            Console.Write("Enter your Name: ");
            string userName = Console.ReadLine();

            // Get user's age with validation
            Console.Write("Enter your Age: ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            // Check eligibility and display result
            if (userAge >=18)
            {
                Console.WriteLine(userName + " You are elegible for Vote");
            }
            else
            {
                Console.WriteLine(userName + " You are not elegible for Vote");
            }

            // Keep console window open
            Console.ReadKey();
        }
    }
}
