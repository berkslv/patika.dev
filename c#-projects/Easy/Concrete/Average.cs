using System;

namespace Easy
{
    public static class Average
    {
        public static float Calculate(float[] numbers)
        {
            float sum = 0;
            
            foreach (float number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }

        public static float Calculate(int[] numbers)
        {
            int sum = 0;
            
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}