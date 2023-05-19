using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Калькулятор,_засунутый_в_событие
{
    class Calculator
    {
        delegate void Calc(double a, double b);
        static event Calc calc_all;

        static void Main()
        {
            Calc div = (double a, double b) => Console.WriteLine($"Деление: {a / b}");
            Calc sub = (double a, double b) => Console.WriteLine($"Вычитание: {a - b}");
            Calc sum = (double a, double b) => Console.WriteLine($"Сложение {a + b}");
            Calc mult = (double a, double b) => Console.WriteLine($"Умножение {a * b}");

            calc_all += div;
            calc_all += sub;
            calc_all += sum;
            calc_all += mult;

            Console.Write("Введите первый операнд ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введите второй операнд ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            calc_all(a, b);
            Console.ReadLine();
        }
    }
}
