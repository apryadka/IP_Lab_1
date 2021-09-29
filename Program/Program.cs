using System;
using SuperLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Функцiя знаходження ваги в повних тонах, якщо вона вiдома в кг.");
            double kilograms = Enter("Введiть кг: ");
            double tons = Lib.ConvertKilogramToTonne(kilograms);
            Console.WriteLine($"Вага у тонах: {Math.Round(tons,3)}");
            Console.WriteLine();

            Console.WriteLine("2) Знаходження суми ряду.");
            double n = Enter("Введiть n: ");
            double a = Enter("Введiть a: ");
            double summ = Lib.Summ((int)n, a);
            Console.WriteLine($"Сума ряду = {Math.Round(summ,3)}");
            Console.WriteLine();

            Console.WriteLine("3) Знаходження суми ряду з заданою точнiстю.");
            double eps = Enter("Введiть точнiсть (e): ");
            double xarg = Enter("Введiть x: ");
            double Summ = Lib.Seps(xarg, eps);
            double x = 1 / 4 * Math.Log((1 + xarg) / (1 - xarg)) + 0.5 * Math.Atan(xarg); // обчислення точного значення
            double t = (Math.Abs(Summ - x) / x) * 100; // обчислення помилки
            Console.WriteLine($"Сума ряду = {Summ}, точне значення = {x}, помилка = {Math.Round(t, 3)} %");
            Console.ReadLine();
        }

        public static double Enter(string text)
        {
            double n;
            Console.Write(text);
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Невірні дані");
                Console.Write("Спробуйте ще раз : ");
            }
            return n;
        }   
    }
}
