namespace Assignment2_5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("______Area Calculator_______");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Exit");
                Console.WriteLine("______________________________");
                Console.Write("Enter your choice (1-5): ");

                // Get user choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                }

                switch (choice)
                {
                    case 1: // Rectangle
                        //declaring variable, etting user input and validating

                        double length;
                        Console.Write("Enter the length of the rectangle: ");

                        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }

                        double breadth;
                        Console.Write("Enter the breadth of the rectangle: ");

                        while (!double.TryParse(Console.ReadLine(), out breadth) || breadth <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }

                        double rectangleArea = length * breadth;
                        Console.WriteLine($"The area of the rectangle is {rectangleArea}.\n");
                        break;

                    case 2: // Circle
                            //declaring variable, etting user input and validating

                        double radius;
                        Console.Write("Enter the radius of the circle: ");
                        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }

                        double circleArea = Math.PI * radius * radius;
                        Console.WriteLine($"The area of the circle is {circleArea:F2}.\n");
                        break;

                    case 3: // Triangle
                            //declaring variable, etting user input and validating
                        double baseTriangle;
                        Console.Write("Enter the base of the triangle: ");

                        while (!double.TryParse(Console.ReadLine(), out baseTriangle) || baseTriangle <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }

                        //declaring variable, etting user input and validating
                        double heightTriangle;
                        Console.Write("Enter the height of the triangle: ");
                        while (!double.TryParse(Console.ReadLine(), out heightTriangle) || heightTriangle <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }


                        double triangleArea = 0.5 * baseTriangle * heightTriangle;
                        Console.WriteLine($"The area of the triangle is {triangleArea}.\n");
                        break;

                    case 4: // Square
                            //declaring variable, etting user input and validating
                        double side;
                        Console.Write("Enter the length of the square: ");
                        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                        {
                            Console.Write("Invalid input! Please enter a positive number: ");
                        }
                        double squareArea = side * side;
                        Console.WriteLine($"The area of the square is {squareArea}.\n");
                        break;

                    case 5: // Exit
                        Console.WriteLine("Exiting the program.................");
                        break;
                }

            } while (choice != 5);

            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey();

        }

    }
}