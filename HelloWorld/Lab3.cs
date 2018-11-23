using System;
using static System.Math;

namespace HelloWorld
{
    class Lab3
    {
        //Исправить
        public static void Run()
        {
            Console.WriteLine("Циклическое вычисление:");

            double a = PI / 5;
            double b = 9 * a;

            const int k = 10;
            int n;

            double step = (b - a) / k;

            for (double x = a; x <= b; x += step)
            {
                double sn = Cos(x), se = Cos(x);

                for (n = 2; n <= 40; n++)
                    sn += Cos(n * x) / n;

                n = 2;
                double member;

                do
                {
                    member = Cos(n * x) / n;
                    se += member;
                    n++;
				} while (1 / (double)n > 0.0001);

                double y = -Log(Abs(2 * Sin(x / 2)));

                Console.WriteLine($"X = {x:f7} \t SN = {sn:f7} \t SE = {se:f7} \t Y = {y:f7}");
            }
        }
    }
}
