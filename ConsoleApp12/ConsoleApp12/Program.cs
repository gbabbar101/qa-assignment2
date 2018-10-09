using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program    {        static void Main(string[] args)        {            TriangleSolver t = new TriangleSolver();

            int aValue, bValue, cValue;            string a, b, c;
            string InputValue = string.Empty;            bool validMenuSelection = false;            try            {                while (validMenuSelection == false)                {                    Console.WriteLine("Press 1: Enter Dimensions of a Triangle");                    Console.WriteLine("Press 2: Exit");                    InputValue = Console.ReadLine();                    if (InputValue == "1")                    {                        Console.WriteLine("Enter 3 values as sides of Triangle");                        a = Console.ReadLine();                        bool a1 = int.TryParse(a, out aValue);                        if (!(a1))                        {                            Console.WriteLine("The entered value is not valid");                        }                        b = Console.ReadLine();                        bool b1 = int.TryParse(b, out bValue);                        if (!(b1))                        {                            Console.WriteLine("The entered value is not valid");                        }                        c = Console.ReadLine();                        bool c1 = int.TryParse(c, out cValue);                        if (!(c1))                        {                            Console.WriteLine("The entered value is  not valid");                        }

                        t.Analyze(aValue, bValue, cValue);

                    }                    else if (InputValue == "2")                    {                        System.Environment.Exit(0);                    }                    else                    {                        Console.WriteLine("Please enter a valid value");                    }                }            }            catch (Exception e)            {                Console.WriteLine(e.Message);            }        }    }}
