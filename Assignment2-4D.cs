namespace Assignment2_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decalaring variables for rollno, name, marks and 3 subjects
            int rollNo;
            string StudentName;
            double mathsMark, physicsMark, chemistryMark;

            //getting values from user
            //getting roll no
            Console.Write("Enter Admission Number: ");
            while (!int.TryParse(Console.ReadLine(), out rollNo))
            {
                Console.WriteLine("Roll Number Should be an integer!! Enter Roll No: ");
            }

            //getting name
            Console.Write("Enter Student Name:  ");
            string studentName = Console.ReadLine();

            //getting mark of Maths 
            do
            {
                Console.Write("Enter Maths mark: ");
                while (!double.TryParse(Console.ReadLine(), out mathsMark) || mathsMark < 0 || mathsMark > 100)
                {
                    Console.WriteLine("Mark should be a positive number and less than or equal to 100!!");
                    Console.Write("Enter Mark of Maths: ");
                }

                if (mathsMark < 65)
                {
                    Console.WriteLine("You are not eligible for admission your Maths Mark is less than 65.");
                }
            }
            while (mathsMark < 0 && mathsMark > 100 && mathsMark < 65);

            Console.WriteLine("Mark accepted.");


            //getting mark of physics
            do
            {
                Console.Write("Enter Mark of physics: ");
                if (!double.TryParse(Console.ReadLine(), out physicsMark) || physicsMark < 0 || physicsMark > 100)
                {
                    Console.WriteLine("Mark should be a positive number less than or equal to 100!!");
                    Console.Write("Enter Mark of physics: ");
                }

                if (physicsMark < 55)
                {
                    Console.WriteLine("You are not eligible your physics mark is less than 55");
                }
            }
            while (physicsMark < 0 || physicsMark > 100 || physicsMark < 55);

            Console.WriteLine("Mark accepted.");

            //getting mark of Chemistry
            do
            {
                Console.Write("Enter Mark of chemistry: ");
                while (!double.TryParse(Console.ReadLine(), out chemistryMark) || chemistryMark < 0 || chemistryMark > 100)
                {
                    Console.WriteLine("Mark should be a positive number less than or equal to 100!!");
                    Console.Write("Enter Mark of chemistry: ");
                }

                if (chemistryMark < 50)
                {
                    Console.WriteLine("You are not eligible, your chemistry mark is less than 50");
                }
            }
            while (chemistryMark < 0 || chemistryMark > 100 || chemistryMark < 50);

            Console.WriteLine("Mark accepted.");

            //calculating total
            double totalMarks = mathsMark + physicsMark + chemistryMark;

            //calculating percentage
            double percentageMark = (totalMarks / 300) * 100;

            //calculating division


            //Displaying Result
            Console.WriteLine("------Student Allotment Result-------");
            Console.WriteLine($"Roll No     : {rollNo}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Maths       : {mathsMark}");
            Console.WriteLine($"Physics     : {physicsMark}");
            Console.WriteLine($"Chemistry   : {chemistryMark}");
            Console.WriteLine($"Total Marks : {totalMarks}");
            Console.WriteLine($"Percentage  : {percentageMark}");
            if (totalMarks >= 180 || mathsMark + physicsMark >= 140 || mathsMark + chemistryMark >= 140)
            {
                Console.WriteLine(studentName + "you are elegible for admission");
            }
            //else if (mathsMark + physicsMark >= 140 || mathsMark + chemisryMark >= 140)
            //{
            //    Console.WriteLine(studentName + "you are eligible for Adimission");
            //}
            else
            {
                Console.WriteLine(studentName + "  you are not elegible for admission");
            }

        }
    }
}

//read rollno, name and marks of the three subjects
//calculate total, percentage and division

