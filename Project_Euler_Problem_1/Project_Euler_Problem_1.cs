using System;
using System.Collections.Generic;
using System.Linq;


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
            Console.WriteLine("\nThe sum of all the multiples of the user supplied integers is : " + AddMultiplesToList.returnCustomMultiplesBelowOneThousand().Sum());
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
        public static List<int> returnCustomMultiplesBelowOneThousand()
        {
            Console.Write("Enter integer 1: ");
            int integerOne = CustomMathematics.askForInt();

            Console.Write("Enter integer 2: ");
            int integerTwo = CustomMathematics.askForInt();

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
}