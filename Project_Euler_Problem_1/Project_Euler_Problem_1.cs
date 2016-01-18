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
                AddMultiplesToList.ReturnMultiplesOfThreeAndFiveBelowOneThousand().Sum());
        }
    }

    public static class AddMultiplesToList
    {
        public static List<int> ReturnMultiplesOfThreeAndFiveBelowOneThousand()
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
    }
}