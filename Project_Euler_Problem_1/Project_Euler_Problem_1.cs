using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Project_Euler_Problem_1
{
    // Class containing main entry point of the application
    class ProjectEulerProblem1
    {
        static void Main()
        {
            // Title
            Console.WriteLine("********** Project Euler: Problem One **********\n");

            // Output the results to the console window
            Console.WriteLine("\nThe sum of all the multiples of the user supplied integers is : " + AddMultiplesToList.returnCustomeMultiplesBelowOneThousand().Sum());
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is : " + AddMultiplesToList.returnMultiplesOfThreeAndFiveBelowOneThousand().Sum());
            Console.WriteLine("The sum of all the multiples of 6 or 9 below 1000 is : " + AddMultiplesToList.returnMultiplesOfSixAndNineBelowOneThousand().Sum());
        }
    }

    // Static Class containing methods that add multiples of an integer below 1000 to a list
    public static class AddMultiplesToList
    {
        // Adds an integer to the list if it is a multiple of 3 or 5 below 1000
        public static List<int> returnMultiplesOfThreeAndFiveBelowOneThousand()
        {
            List<int> multiplesOfThreeAndFive = new List<int>();

            for (int multiple = 1; multiple < 1000; multiple++)
            {
                if (CustomMathematics.IsDivisible(multiple, 3))
                {
                    multiplesOfThreeAndFive.Add(multiple);
                }
                else if (CustomMathematics.IsDivisible(multiple, 5))
                {
                    multiplesOfThreeAndFive.Add(multiple);
                }
            }

            return multiplesOfThreeAndFive;
        }

        // Adds an integer to the list if it is a multiple of 6 or 9 below 1000
        public static List<int> returnMultiplesOfSixAndNineBelowOneThousand()
        {
            List<int> multiplesOfSixAndNine = new List<int>();

            for (int multiple = 1; multiple < 1000; multiple++)
            {
                if (CustomMathematics.IsDivisible(multiple, 6))
                {
                    multiplesOfSixAndNine.Add(multiple);
                }
                else if (CustomMathematics.IsDivisible(multiple, 9))
                {
                    multiplesOfSixAndNine.Add(multiple);
                }
            }

            return multiplesOfSixAndNine;
        }

        // Adds an integer to the list if it is a multiple of the user supplied integer below 1000
        public static List<int> returnCustomeMultiplesBelowOneThousand()
        {
            Console.Write("Enter Integer 1: ");
            string integerOne = Console.ReadLine();

            Console.Write("Enter Integer 2: ");
            string integerTwo = Console.ReadLine();

            List<int> customMultiplesBelowOneThousand = new List<int>();

            for (int multiple = 1; multiple < 1000; multiple++)
            {
                if (CustomMathematics.IsDivisible(multiple, Convert.ToInt32(integerOne)))
                {
                    customMultiplesBelowOneThousand.Add(multiple);
                }
                else if (CustomMathematics.IsDivisible(multiple, Convert.ToInt32(integerTwo)))
                {
                    customMultiplesBelowOneThousand.Add(multiple);
                }
            }

            return customMultiplesBelowOneThousand;
        }
    }

    // Static Maths Class: Scope to add further methods and create a Class Library from this for use in further Euler problems
    public static class CustomMathematics
    {
        // Returns true or false whether an integer is a multiple of another integer
        public static bool IsDivisible(int multiple, int integer)
        {
            return (multiple % integer) == 0;
        }
    }

    // Test Class using Xunit
    public class TestClass
    {
        // Test the correct answer against the answer that the solution provides
        [Fact]
        public void testAnswerIsCorrect()
        {
            int expected = 233168;
            int actual = AddMultiplesToList.returnMultiplesOfThreeAndFiveBelowOneThousand().Sum();
            Assert.Equal(expected, actual);
        }

        // Test to ensure that the IsDivisble method returns true when an integer is a multiple of another
        [Fact]
        public void testIsDivisible()
        {
            Assert.True(CustomMathematics.IsDivisible(10,5));
        }

        // Test to ensure that the IsDivisble method returns false when an integer isn't a multiple of another
        [Fact]
        public void testIsNotDivisible()
        {
            Assert.False(CustomMathematics.IsDivisible(28,13));
        }
    }
}