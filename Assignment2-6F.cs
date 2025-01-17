namespace Assignment2_6F
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("__________Simple Calculator____________");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("_________________________________________");
                Console.Write("Enter your choice (1-5): ");

                // Get user choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                }

                switch (choice)
                {
                    case 1: // Addition
                        double num1, num2;
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        double sum = num1 + num2;
                        Console.WriteLine($"The result of addition is: {sum}\n");
                        break;

                    case 2: // Subtraction
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        double difference = num1 - num2;
                        Console.WriteLine($"The result of subtraction is: {difference}\n");
                        break;

                    case 3: // Multiplication
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        double product = num1 * num2;
                        Console.WriteLine($"The result of multiplication is: {product}\n");
                        break;

                    case 4: // Division
                        Console.Write("Enter the numerator: ");
                        while (!double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.Write("Invalid input! Please enter a valid number: ");
                        }

                        Console.Write("Enter the denominator: ");
                        while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                        {
                            Console.Write("Invalid input! Denominator must be a valid non-zero number: ");
                        }

                        double quotient = num1 / num2;
                        Console.WriteLine($"The result of division is: {quotient:F2}\n");
                        break;

                    case 5: // Exit
                        Console.WriteLine("Exiting the program.................");
                        break;
                }

            } while (choice != 5);
            Console.Clear();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }

}