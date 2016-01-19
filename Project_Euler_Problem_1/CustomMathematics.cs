using System;

namespace Project_Euler_Problem_1
{
    public static class CustomMathematics
    {
        // Get rid of params by having making functions
        public static bool IsDivisibleBy3(int i)
        {
            return i%3 == 0;
        }

        public static bool IsDivisibleBy5(int i)
        {
            return IsDivisible(i, 3);
        }

        // Returns true or false whether an integer is a multiple of another integer
        public static bool IsDivisible(int multiple, int integer)
        {
            return (multiple % integer) == 0;
        }

        public static int AskForInt()
        {
            int integer;
            while (true)
            {
                string readline = Console.ReadLine();
                if (int.TryParse(readline, out integer))
                {
                    return integer;
                }
                Console.WriteLine("Please enter an integer");
            }
        }
    }
}
