using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Project_Euler_Problem_1
{
    // Console output displaying the answer to the problem
    class ProjectEulerProblem1
    {
        static void Main()
        {
            List<int> multiplesOfThreeAndFive = AddMultiplesOfThreeAndFiveToList.AddMultiplesToList();
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is : " + multiplesOfThreeAndFive.Sum());
        }
    }

    // Adds multiples of 3 and 5 to a list that meet the criteria and returns the list
    class AddMultiplesOfThreeAndFiveToList
    {
        // Returns whether a given number is a multiple of another given number
        private static bool IsDivisible(int multiple, int number)
        {
            return (multiple % number) == 0;
        }

        // Adds a number to the list if it is a multiple of 3 or 5
        public static List<int> AddMultiplesToList()
        {
            List<int> multiplesOfThreeAndFive = new List<int>();

            for (int multiple = 0; multiple < 1000; multiple++)
            {
                if (IsDivisible(multiple, 3))
                {
                    multiplesOfThreeAndFive.Add(multiple);
                }
                else if (IsDivisible(multiple, 5))
                {
                    multiplesOfThreeAndFive.Add(multiple);
                }
            }

            return multiplesOfThreeAndFive;
        }
    }

    // A test class to compare the correct answer to the problem against the answer provided by the code soltion
    public class TestClass
    {
        [Fact]
        public void TestAnswerIsCorrect()
        {
            List<int> multiplesOfThreeAndFive = AddMultiplesOfThreeAndFiveToList.AddMultiplesToList();
            Assert.Equal(233168, multiplesOfThreeAndFive.Sum());
        }
    }
}