using System;

namespace calculatorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = 0;
            Console.WriteLine("Please enter how many digits to calculate to: ");
            digits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calculate(digits));
        }

        static double calculate(int digits)
        {
            //Set up masses. m1 is the block on the left, m2 the right.
            var m1 = 1;
            var m2 = Math.Pow(100, (digits - 1));

            //Initial velocity of the left and right block respectively.
            double u1 = 0.0;
            double u2 = -1.0;

            //Initialise empty v1 and v2 to be used later.
            double v1 = 0.0;
            double v2 = 0.0;

            //In order to save on processing time, some of the equation will be pre-calculated.
            var sumOfMasses = m1 + m2;
            var v1LeftFraction = (m1 - m2) / sumOfMasses;
            var v1RightFraction = (2 * m2) / sumOfMasses;
            var v2LeftFraction = (2 * m1) / sumOfMasses;
            var v2RightFraction = (m2 - m1) / sumOfMasses;

            //A running total of the number of collisions, which is going to be pi.
            double piCalculated = 0.0;

            while (true)
            {
                piCalculated++;
                //If the magnitude of u1 is smaller than u2 and it is negative (so going to the right) then it hits the wall.
                if (u1 < u2 && u1 < 0)
                {
                    u1 = -u1;
                }
                //Otherwise, it changes momentum.
                else
                {
                    v1 = v1LeftFraction * u1 + v1RightFraction * u2;
                    v2 = v2LeftFraction * u1 + v2RightFraction * u2;
                    u1 = v1;
                    u2 = v2;
                }
                if (u1 < u2 && u1 > 0)
                {
                    break;
                }
            }

            return piCalculated;
        }
    }
}