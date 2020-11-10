using System;

namespace Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {

            double passGrade = 90; //change grade to reflect changes in program
            double grade1 = 92;
            double grade2 = 88;
            double grade3 = 77;
            double passFail = 91; //change grade to reflect changes in program

            //IsPassing(passGrade);
            //AverageGrades(grade1, grade2, grade3);
            OddorEvenAndPassing(passFail);
            Console.WriteLine($"{passGrade} {grade1} {grade2} {grade3} {passFail}"); // displaying numbers for my own sanity
        }



        //public static bool IsPassing(double passGrade)
        //{
        //    if (passGrade > 65)
        //    {
        //        Console.WriteLine("true");
        //        return true;
                
               
        //    }
        //    else
        //    {
        //        Console.WriteLine("false");
        //        return false;
        //    }
        //}
        //public static double AverageGrades(double grade1, double grade2, double grade3)
        //{
        //    double average = (grade1 + grade2 + grade3) / 3;
        //    //Console.WriteLine($"{average}");
        //    return average;
        //}
        public static string OddorEvenAndPassing(double passFail)
        {
            string oddEven = "";
            bool IsPassing = true;

            if (passFail % 0 == 1 && passFail > 65)
            {
                Console.WriteLine("passing and odd");
                return "passing and odd";

            }
            else if (passFail % 0 == 1 && passFail <= 65)
            {
                Console.WriteLine("failing and odd");
                return "failing and odd";
            }
            else if (passFail % 0 == 0 && passFail > 65)
            {
                Console.WriteLine("passing and even");
                return "passing and even";
            }
            else if (passFail % 0 == 0 && passFail <= 65)
            {
                Console.WriteLine("failing and even");
                return "failing and even";
            }
            return oddEven;
        }
    }
}
