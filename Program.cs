using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1._4
{
  
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students5A, students5B;

            students5A = new string[10] { "Raj", "Sita", "Mukul", "Ajay", "Ram", "Geeta", "Jay", "Rohit", "Gopal", "Meera" };
            students5B = new string[10] { "Pihu", "Rakesh", "Rajeev", "Mukesh", "Deepk", "Suresh", "Gopi", "Tina", "Chandrika", "Ann" };

            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";

            int[] marks = new int[6];
            marks[0] = 78;
            marks[1] = 87;
            marks[2] = 98;
            marks[3] = 59;
            marks[4] = 78;
            marks[5] = 92;

            Console.WriteLine("Students of Class 5A:");
            foreach (string s in students5A)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class 5B:");
            foreach (string s in students5B)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Ram:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");
        }
    }
}


