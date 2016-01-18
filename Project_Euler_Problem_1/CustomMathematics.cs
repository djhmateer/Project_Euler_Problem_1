using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_1
{
    // Static Maths Class: Scope to add further methods and create a Class Library from this for use in further Euler problems
    public static class CustomMathematics
    {
        // Returns true or false whether an integer is a multiple of another integer
        public static bool IsDivisible(int multiple, int integer)
        {
            return (multiple % integer) == 0;
        }

        public static int askForInt()
        {
            int integer;
            while (true)
            {
                string readline = Console.ReadLine();
                if (int.TryParse(readline, out integer) && integer < 1000 && integer > 0)
                {
                    return integer;
                }
                Console.WriteLine("Please enter a positive integer below 1000");
            }
        }
    }
}
