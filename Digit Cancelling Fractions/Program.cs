using System;

namespace Digit_Cancelling_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            float numerator = 0;
            float denominator;
            float numerator_left;
            float numerator_right;
            float denominator_left;
            float denominator_right;

            float fraction;
            float fraction_test1;

            int correct_numerator = 1;
            int correct_denominator = 1;


            for(int n = 10; n < 100; n++)
            {
                numerator_left = n / 10;
                numerator_right = n % 10;
                numerator = n;
                for (int d = n+1; d < 100; d++)
                {
                        
                    denominator = d;

                    fraction = numerator / denominator;

                    denominator_left = d / 10;
                    denominator_right = d % 10;
                    if (numerator_right == denominator_left)
                    {
                        fraction_test1 = (float)numerator_left / denominator_right;

                        if (fraction_test1 == fraction)
                        {
                            correct_denominator *= d;
                            correct_numerator *= n;
                        }
                    }
                }
            }
            Console.WriteLine(correct_denominator / correct_numerator);
        }
    }
}
