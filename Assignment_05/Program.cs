/*
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int choice = 0;

            //menu
            while (choice != 2)
            {

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Please choose an option below 1 or 2:");
                Console.WriteLine("1. Display Grades");
                Console.WriteLine("2. Exit Program");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                switch (choice)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }

                }
            }

            // code found at http://www.dotnetperls.com/file
            using (StreamReader read = new StreamReader("StudentGrades.txt"))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    string[] student = line.Split(',');
                }


            }
        }
    }
}
