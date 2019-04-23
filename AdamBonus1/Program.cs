using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBonus1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Letter Grade Converter!");
            Console.WriteLine("");
            string willContinue = "y";



            while (willContinue == "y")
            {
                Console.WriteLine("Please enter a numerical grade.");
                string grade = Console.ReadLine();
                double newGrade = Convert.ToDouble(grade);
                


                if (newGrade >= 90)
            {
                Console.WriteLine("A");

            }
            else if (newGrade >= 79)
            {
                Console.WriteLine("B");

            }
            else if (newGrade >= 69)
            {
                Console.WriteLine("C");
            }
            else if (newGrade >= 59)
            {
                Console.WriteLine("D");
            }
            else if (newGrade >= 0)
            {
                Console.WriteLine("F");

            }
            Console.WriteLine("Would you like to enter another grade?");
            willContinue = Console.ReadLine();
        }
                 
            
        
        }
    }
}
