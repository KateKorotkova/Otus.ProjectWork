namespace Otus.ProjectWork.Tasks
{
    public class Tribonacci
    {
        public int RunViaMatrixMultiply(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            int[,] accumulator = {{ 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 }};

            int[,] transitionMatrix = {{ 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 }};

            for (var i = 3; i <= n; i++)
            {
                Multiply(accumulator, transitionMatrix);
            }

            return accumulator[0, 0];
        }

        private void Multiply(int[,] T, int[,] M)
        {
            var firstRowFirstColumn = T[0, 0] * M[0, 0] + T[0, 1] * M[1, 0] + T[0, 2] * M[2, 0];
            var firstRowSecondColumn = T[0, 0] * M[0, 1] + T[0, 1] * M[1, 1] + T[0, 2] * M[2, 1];
            var firstRowThirdColumn = T[0, 0] * M[0, 2] + T[0, 1] * M[1, 2] + T[0, 2] * M[2, 2];
            var secondRowFirstColumn = T[1, 0] * M[0, 0] + T[1, 1] * M[1, 0] + T[1, 2] * M[2, 0];
            var secondRowSecondColumn = T[1, 0] * M[0, 1] + T[1, 1] * M[1, 1] + T[1, 2] * M[2, 1];
            var secondRowThirdColumn = T[1, 0] * M[0, 2] + T[1, 1] * M[1, 2] + T[1, 2] * M[2, 2];
            var thirdRowFirstColumn = T[2, 0] * M[0, 0] + T[2, 1] * M[1, 0] + T[2, 2] * M[2, 0];
            var thirdRowSecondColumn = T[2, 0] * M[0, 1] + T[2, 1] * M[1, 1] + T[2, 2] * M[2, 1];
            var thirdRowThirdColumn = T[2, 0] * M[0, 2] + T[2, 1] * M[1, 2] + T[2, 2] * M[2, 2];
            T[0, 0] = firstRowFirstColumn;
            T[0, 1] = firstRowSecondColumn;
            T[0, 2] = firstRowThirdColumn;
            T[1, 0] = secondRowFirstColumn;
            T[1, 1] = secondRowSecondColumn;
            T[1, 2] = secondRowThirdColumn;
            T[2, 0] = thirdRowFirstColumn;
            T[2, 1] = thirdRowSecondColumn;
            T[2, 2] = thirdRowThirdColumn;
        }

        public int RunIterationWithoutAdditionalMemory(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            var first = 0;
            var second = 1;
            var third = 1;

            var result = first + second + third;
            for (var i = 3; i < n; i++)
            {
                first = second;
                second = third;
                third = result;
                result = first + second + third;
            }

            return result;
        }

        public int RunIteration(int n)
        {
            var cache = new int[n + 1];

            for (var i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    cache[i] = 0;
                    continue;
                }

                if (i == 1 || i == 2)
                {
                    cache[i] = 1;
                    continue;
                }

                cache[i] = cache[i - 3] + cache[i - 2] + cache[i - 1];
            }

            return cache[n];
        }

        public int RunRecursion(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            return RunRecursion(n - 1) + RunRecursion(n - 2) + RunRecursion(n - 3);
        }
    }
}
