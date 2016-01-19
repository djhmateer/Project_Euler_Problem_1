using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler_Problem_1
{
    class ProjectEulerProblem1
    {
        static void Main()
        {
            Console.WriteLine("********** Project Euler: Problem One **********\n");
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is : " +
                AddMultiplesToList.MultiplesOfThreeAndFiveBelowOneThousand().Sum());
        }
    }

    public static class AddMultiplesToList
    {
        public static List<int> MultiplesOfThreeAndFiveBelowOneThousand()
        {
            var multiplesOfThreeAndFive = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (CustomMathematics.IsDivisibleBy3(i))
                {
                    multiplesOfThreeAndFive.Add(i);
                }
                else if (CustomMathematics.IsDivisible(i, 5))
                {
                    multiplesOfThreeAndFive.Add(i);
                }
            }
            return multiplesOfThreeAndFive;
        }
    }
}