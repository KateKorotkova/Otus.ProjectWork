using NUnit.Framework;
using Otus.ProjectWork.Tasks;

namespace Tests
{
    public class TribonacciTests
    {
        [TestCase(4, ExpectedResult = 4)]
        [TestCase(5, ExpectedResult = 7)]
        [TestCase(9, ExpectedResult = 81)]
        public int Can_Calculate_Via_Recursion(int n)
        {
            var algorithm = new Tribonacci();

            return algorithm.RunRecursion(n);
        }

        [TestCase(4, ExpectedResult = 4)]
        [TestCase(5, ExpectedResult = 7)]
        [TestCase(9, ExpectedResult = 81)]
        public int Can_Calculate_Via_Iteration(int n)
        {
            var algorithm = new Tribonacci();

            return algorithm.RunIteration(n);
        }

        [TestCase(4, ExpectedResult = 4)]
        [TestCase(5, ExpectedResult = 7)]
        [TestCase(9, ExpectedResult = 81)]
        public int Can_Calculate_Via_Iteration_Without_Additional_Memory(int n)
        {
            var algorithm = new Tribonacci();

            return algorithm.RunIterationWithoutAdditionalMemory(n);
        }

        [TestCase(4, ExpectedResult = 4)] 
        [TestCase(5, ExpectedResult = 7)] 
        [TestCase(9, ExpectedResult = 81)]
        public int Can_Calculate_Via_Matrix_Multiply(int n)
        {
            var algorithm = new Tribonacci();

            return algorithm.RunIterationWithoutAdditionalMemory(n);
        }
    }
}