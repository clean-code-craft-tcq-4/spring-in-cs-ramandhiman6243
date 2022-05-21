using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public float average;
        public float max;
        public float min;

        public Stats CalculateStatistics(List<float> numbers)
        {
            float sum = 0;
            float max = float.MinValue;
            float min = float.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }

            return new Stats();
        }
    }
}
