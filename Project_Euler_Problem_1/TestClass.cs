using System.Linq;
using Xunit;

namespace Project_Euler_Problem_1
{
    public class TestClass
    {
        // Test the correct answer against the answer that the solution provides
        [Fact]
        public void TestAnswerIsCorrect()
        {
            int expected = 233168;
            int actual = AddMultiplesToList.ReturnMultiplesOfThreeAndFiveBelowOneThousand().Sum();
            Assert.Equal(expected, actual);
        }

        // Test to ensure that the IsDivisble method returns true when an integer is a multiple of another
        [Fact]
        public void TestIsDivisible()
        {
            Assert.True(CustomMathematics.IsDivisible(10, 5));
        }

        // Test to ensure that the IsDivisble method returns false when an integer isn't a multiple of another
        [Fact]
        public void TestIsNotDivisible()
        {
            Assert.False(CustomMathematics.IsDivisible(28, 13));
        }
    }
}
