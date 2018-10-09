using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class TriangleSolver
    {
        //creating class named TriangleSolver
            int x, y, z;
            public TriangleSolver()
            {
            }
        public string Analyze(int x, int y, int z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Invalid Value");
            }
            else if (((x + y) > z) && ((y + z) > x) && ((z + x) > y))
            {
                Console.WriteLine("Triangle:");
                if (x == y && y == z && z == x)
                {
                    Console.WriteLine("The triangle is an Equilateral Triangle");
                    return ("This is a Equilateral triangle");
                }
                else if (x == y || y == z || z == x)
                {
                    Console.WriteLine("The triangle is an Isosceles Triangle");
                    return ("This is a Isosceles triangle");

                }
                else if (x != y && y != z && z != x)
                {
                    Console.WriteLine("The triangle is an Scalene Triangle");
                    return ("This is a Scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("Enter valid values again");
            }
            return ("InvalidEntry");

        }
        
    }
    }

