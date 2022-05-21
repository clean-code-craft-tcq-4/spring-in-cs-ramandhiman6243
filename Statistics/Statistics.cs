using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public StatsComputer()
        {
            average = double.NaN;
            max = double.NaN;
            min = double.NaN;
        }

        public Stats CalculateStatistics(List<double> numbers)
        {
            if (numbers.Count > 0)
            {
                double sum = 0;

                max = double.MinValue;
                min = double.MaxValue;

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];

                    if (numbers[i] > max)
                        max = numbers[i];

                    if (numbers[i] < min)
                        min = numbers[i];
                }

                average = sum / numbers.Count;
            }
            else
            {
                average = double.NaN;
                max = double.NaN;
                min = double.NaN;
            }

            return new Stats();
        }
    }
}
