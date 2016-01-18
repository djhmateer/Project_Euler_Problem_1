using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Project_Euler_Problem_1
{
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
            Assert.True(CustomMathematics.IsDivisible(10, 5));
        }

        // Test to ensure that the IsDivisble method returns false when an integer isn't a multiple of another
        [Fact]
        public void testIsNotDivisible()
        {
            Assert.False(CustomMathematics.IsDivisible(28, 13));
        }
    }
}
