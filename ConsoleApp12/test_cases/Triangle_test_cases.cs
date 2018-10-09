using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp12;
using NUnit.Framework;

namespace test_cases
{
    public class Triangle_test_cases
    {
        public class TriangleTestCases
        {
            [Test]
            public void Analyze_Input5and5and5_resultIsEquilateral()
            {
                //Arrange
                int value1 = 5;
                int value2 = 5;
                int value3 = 5;
                string result = "This is a Equilateral triangle";
                TriangleSolver triangle= new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }

            [Test]
            public void Analyze_Input5and5and8_resultIsIsosceles()
            {
                //Arrange
                int value1 = 5;
                int value2 = 5;
                int value3 = 8;
                string result = "This is a Isosceles triangle";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }

            [Test]
            public void Analyze_Input4and7and9_resultIsScalene()
            {
                //Arrange
                int value1 = 4;
                int value2 = 7;
                int value3 = 9;
                string result = "This is a Scalene triangle";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }

            [Test]
            public void Analyze_Input123and100and1_InvalidEntry()
            {
                //Arrange
                int value1 = 123;
                int value2 = 100;
                int value3 = 1;
                string result = "InvalidEntry";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }

            [Test]
            public void Analyze_Input1and5and0_InvalidEntry()
            {
                //Arrange
                int value1 = 1;
                int value2 = 5;
                int value3 = 0;
                string result = "InvalidEntry";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }
            [Test]
            public void Analyze_Inputnegative1andnegative5and0_InvalidEntry()
            {
                //Arrange
                int value1 = -1;
                int value2 = -5;
                int value3 = 0;
                string result = "InvalidEntry";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }
            [Test]
            public void Analyze_Input0and0and0_InvalidEntry()
            {
                //Arrange
                int value1 = 0;
                int value2 = 0;
                int value3 = 0;
                string result = "InvalidEntry";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }
            [Test]
            public void Analyze_Inputnegative1andnegative2andnegative3_InvalidEntry()
            {
                //Arrange
                int value1 = -1;
                int value2 = -2;
                int value3 = -3;
                string result = "InvalidEntry";
                TriangleSolver triangle = new TriangleSolver();

                //Act
                string action = triangle.Analyze(value1, value2, value3);

                //Assert
                Assert.AreEqual(result, action);
            }
        }
    }
}
