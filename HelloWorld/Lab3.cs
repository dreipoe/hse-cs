using static System.Console;
using static System.Math;

namespace HelloWorld
{
    class Lab3
    {
        public static void Run()
        {
            WriteLine("Циклическое вычисление:");

            double a = PI / 5;
            double b = 9 * a;
            double step = (b - a) / 10;

            for (double x = a; x <= b; x += step)
            {
                //инициализируем переменные сразу первым членом, чтобы избежать пустой операции умножения/деления на 1.
                double sn = Cos(x), se = sn;
                int n;

                double member;
                for (n = 2; n <= 50; n++)
                    sn += Cos(n * x) / n;

                n = 2;
                double sqrt2 = 1 / Sqrt(2);

                do
                {
                    member = Cos(n * x) / n;
                    se += member;
                    n++;
				} while (sqrt2 / n > 0.0001); //исключим преждевременный выход из цикла, если синусоида окажется слишком близко к нулю

                double y = -Log(
                                Abs(
                                    2 * Sin(x / 2)
                                )
                            );

                WriteLine($"X = {x:f7} \t SN = {sn:f7} \t SE = {se:f7} \t Y = {y:f7}");
            }
        }
    }
}
