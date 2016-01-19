using System;

namespace Project_Euler_Problem_1
{
    public static class CustomMathematics
    {
        // Get rid of params by having making functions
        public static bool IsDivisibleBy3(int i)
        {
            return IsDivisible(3, i);
        }

        public static bool IsDivisibleBy5(int i)
        {
            return IsDivisible(5, i);
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
