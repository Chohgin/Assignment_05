/*Assignent 5 - IO and Exception Handling
 *Nicholas Walker
 *25/03/2015
 *Program that stores data from a file and displays it to the user.
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
            while (choice != 3)
            {

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Please choose an option below 1 or 2:");
                Console.WriteLine("1. Display Grades");
                Console.WriteLine("2. Exit Program");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                choice = Convert.ToInt32(Console.ReadLine());
                
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Please enter the name of your file:");
                                input = Console.ReadLine();
                                try
                                {
                                    // code found at http://www.dotnetperls.com/file
                                    using (StreamReader read = new StreamReader(input))
                                    {
                                        string line;
                                        while ((line = read.ReadLine()) != null)
                                        {
                                            string[] student = line.Split(',');
                                        }
                                    }
                                }
                                catch(Exception error)
                                {
                                    Console.WriteLine("File does not exist. Please try again");
                                    Console.WriteLine("Please press any key to continue");
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice = 0;
                                }
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine();
                                Console.WriteLine("Please press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                                choice = 0;
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Thank you, have a nice day");
                                Console.WriteLine("Press any key to conintue");
                                Console.ReadKey();
                                choice = 3;
                                break;
                            }

                    }
               
            }

           
        }
    }
}
