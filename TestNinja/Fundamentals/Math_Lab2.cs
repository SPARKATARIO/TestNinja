using System;

namespace TestNinja.Fundamentals
{
    public class Math_Lab2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Возвращает массив нечётных чисел от 1 до limit включительно.
        public int[] GetOddNumbers(int limit)
        {
            if (limit < 1)
                return new int[0];

            int count = (limit + 1) / 2;
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
                result[i] = 2 * i + 1;

            return result;
        }
    }
}
