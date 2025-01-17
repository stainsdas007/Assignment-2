namespace Assignment2_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decalaring variables for rollno, name, marks and 3 subjects
            int rollNo;
            string StudentName;
            double subject1Mark, subject2Mark, subject3Mark;

            //getting values from user
            //getting roll no
            Console.Write("Enter Roll No: ");
            while (!int.TryParse(Console.ReadLine(), out rollNo))
            {
                Console.WriteLine("Roll Number Should be an integer!! Enter Roll No: ");
            }

            //getting name
            Console.Write("Enter Student Name:  ");
            string studentName = Console.ReadLine();


            //getting mark of first subject
            Console.Write("Enter Mark of Subject1 : ");
            while (!double.TryParse(Console.ReadLine(), out subject1Mark) && subject1Mark < 0 || subject1Mark > 100)
            {
                Console.WriteLine("Mark should be a positive number less than or equal to 100!!\n Enter Mark of Subject1 ");
            }

            //getting mark of second subject
            Console.Write("Enter Mark of Subject2 : ");
            while (!double.TryParse(Console.ReadLine(), out subject2Mark) && subject2Mark < 0 || subject2Mark > 100)
            {
                Console.WriteLine("Mark should be a positive number less than or equal to 100!!\n Enter Mark of Subject1 ");
            }

            //getting mark of third subject
            Console.Write("Enter Mark of Subject3 : ");
            while (!double.TryParse(Console.ReadLine(), out subject3Mark) && subject3Mark < 0 || subject3Mark > 100)
            {
                Console.WriteLine("Mark should be a positive number less than or equal to 100!!\n Enter Mark of Subject1 ");
            }

            //calculating total
            double totalMarks = subject1Mark + subject2Mark + subject3Mark;

            //calculating percentage
            double percentageMark = (totalMarks / 300) * 100;

            //calculating division
            string division;

            //checking condition
            if (percentageMark < 80)
            {
                division = "Distiction";
            }
            else if (percentageMark >= 70 && percentageMark <= 80)
            {
                division = "First class";
            }
            else if (percentageMark >= 60 && percentageMark <= 70)
            {
                division = "First class";
            }
            else if (percentageMark >= 50 && percentageMark <= 40)
            {
                division = "First class";
            }
            else
            {
                division = "fail";
            }


            //Displaying Result
            Console.WriteLine("-------------Result--------------");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Mark 1: {subject1Mark}");
            Console.WriteLine($"Mark 2: {subject2Mark}");
            Console.WriteLine($"Mark 3: {subject3Mark}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentageMark}");
            Console.WriteLine($"Division: {division}");
        }
    }
}

//read rollno, name and marks of the three subjects
//calculate total, percentage and division