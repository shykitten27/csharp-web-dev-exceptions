using System;
using System.Collections.Generic;
using System.IO;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            double result = 0.0;
            result = x/y;
            if(y==0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero.");
            }
            else 
            { 
            return result;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            int points = 0;

            if (fileName == "" || fileName == null)
            {
                throw new NullReferenceException("Invalid file name.");
            }
            if (fileName.EndsWith(".cs"))
            {
                points = 1;
            }
            else
            {
                points = 0;
            }
            return points;
        }


        static void Main(string[] args)
        {
            try
            {
                Divide(100,0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    CheckFileExtension(student.Value);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message + " " + student.Key + " " + student.Value);
                }
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }
    }
}
