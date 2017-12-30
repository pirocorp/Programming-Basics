using System;

namespace CrossingSequences
{
    class CrossingSequences
    {
        static void Main(string[] args)
        {
            var tribA = int.Parse(Console.ReadLine());
            var tribB = int.Parse(Console.ReadLine());
            var tribC = int.Parse(Console.ReadLine());

            var tribonacciFirst = tribA;
            var tribonacciSecond = tribB;
            var tribonacciThird = tribC;

            var spiralA = int.Parse(Console.ReadLine());
            var spiralStep = int.Parse(Console.ReadLine());

            var spiralIncrement = 1;
            var spiralStepMul = 1;

            var spiralCurrent = spiralA + spiralStep;

            var tribonacciCurrent = tribA + tribB + tribC;
            tribonacciFirst = tribonacciSecond;
            tribonacciSecond = tribonacciThird;
            tribonacciThird = tribonacciCurrent;

            if (spiralCurrent == tribA || spiralCurrent == tribB || spiralCurrent == tribC || spiralCurrent == tribonacciCurrent)
            {
                Console.WriteLine(spiralCurrent);
                return;
            }

            if (spiralA == tribA || spiralA == tribB || spiralA == tribC || spiralA == tribonacciCurrent)
            {
                Console.WriteLine(spiralA);
                return;
            }

            while (tribonacciCurrent <= 1000000 && spiralCurrent <= 1000000) 
            {
                if (spiralCurrent == tribonacciCurrent)
                {
                    Console.WriteLine(tribonacciCurrent);
                    return;
                }
                else if (tribonacciCurrent < spiralCurrent)
                {
                    tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
                    tribonacciFirst = tribonacciSecond;
                    tribonacciSecond = tribonacciThird;
                    tribonacciThird = tribonacciCurrent;
                }
                else
                {
                    spiralCurrent += spiralStepMul * spiralStep;
                    spiralIncrement++;

                    if (spiralCurrent == tribA || spiralCurrent == tribB || spiralCurrent == tribC || spiralCurrent == tribonacciCurrent)
                    {
                        Console.WriteLine(spiralCurrent);
                        return;
                    }

                    if (spiralIncrement == 2)
                    {
                        spiralStepMul++;
                        spiralIncrement = 0;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
