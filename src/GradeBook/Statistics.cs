using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average => Sum / Count;
        public double High;
        public double Low;

        public char Letter
        {
            get
            {
                return Average switch
                {
                    var d when d >= 90.0 => 'A',
                    var d when d >= 80.0 => 'B',
                    var d when d >= 70.0 => 'C',
                    var d when d >= 60.0 => 'D',
                    _ => 'F'
                };
            }
        }

        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}