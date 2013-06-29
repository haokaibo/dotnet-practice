using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPractice
{
    public class TwentyFourPointsGame
    {
        /// <summary>
        /// Using the Threshold for the precision of the calculation to avoid the inaccurate of the double type.
        /// </summary>
        private const double Threshold = 1E-6;
        private const int CardsNumber = 4;
        private const int ResultValue = 24;
        public double[] number = new double[CardsNumber];
        public string[] result = new string[CardsNumber];

        public bool PointsGame(int n)
        {
            // if there is only the result in the number list then just check if the result is the ResultValue.
            if (n == 1)
            {
                if (Math.Abs(number[0] - ResultValue) < Threshold)
                {
                    Console.WriteLine(result[0]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double a = number[i], b = number[j];
                    string expa = result[i], expb = result[j];
                    number[j] = number[n - 1];
                    result[j] = result[n - 1];

                    /*
                     * a[4] = {1, 2, 3, 4} n = 2
                     * a[4] = {3, 4, 3, 4} n = 3
                     * a[4] = {7, 3, 3, 4} n = 2
                     * a[4] = {10, 3, 3, 4} n =1 
                     * */

                    number[i] = a + b;
                    result[i] = '(' + expa + '+' + expb + ')';
                    if (PointsGame(n - 1))
                    {
                        return true;
                    }

                    number[i] = a - b;
                    result[i] = '(' + expa + '-' + expb + ')';
                    if (PointsGame(n - 1))
                    {
                        return true;
                    }

                    number[i] = b - a;
                    result[i] = '(' + expb + '-' + expa + ')';
                    if (PointsGame(n - 1))
                    {
                        return true;
                    }

                    number[i] = a * b;
                    result[i] = '(' + expa + '*' + expb + ')';
                    if (PointsGame(n - 1))
                    {
                        return true;
                    }

                    if (b != 0)
                    {
                        number[i] = a / b;
                        result[i] = '(' + expa + '/' + expb + ')';
                        if (PointsGame(n - 1))
                        {
                            return true;
                        }
                    }

                    if (a != 0)
                    {
                        number[i] = b / a;
                        result[i] = '(' + expb + '/' + expa + ')';
                        if (PointsGame(n - 1))
                        {
                            return true;
                        }
                    }

                    number[i] = a;
                    number[j] = b;
                    result[i] = expa;
                    result[j] = expb;
                }// end of 'for (int j = i + 1; j < n; j++)'
            }// end of 'for (int i = 0; i < n; i++)'
            return false;
        }

    }
}
