using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] eg1 = new double[1000];
            Random randNum = new Random();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write((eg1[i] = randNum.Next(1000, 10000)) + " ");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        public static double eg1 {double Minvalue, double Maxvalue};
        {
           
        }
    }
}
