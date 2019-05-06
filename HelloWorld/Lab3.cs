using static System.Console;
using static System.Math;

namespace HelloWorld
{
    class Lab3
    {
        // TODO: Что-то здесь не так

        public static void Run()
        {
            WriteLine("Циклическое вычисление:");

            double a = PI / 5;
            double b = 9 * a;
            double step = (b - a) / 10;

            for (double x = a; x <= b; x += step)
            {
                //инициализируем переменные сразу первым членом
                double sn = Cos(x), se = sn, pre = se;
                int n;

                for (n = 2; n <= 40; n++)
                    sn += Cos(n * x) / n;

                n = 2;
                double r;

                do
                {
                    se += Cos(n * x) / n;
                    r = Abs(se - pre);
                    pre = se;
                    n++;
				} while (r > 0.0001);

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
