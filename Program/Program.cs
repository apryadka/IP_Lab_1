using System;
using SuperLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Функцiя знаходження ваги в повних тонах, якщо вона вiдома в кг.");
            double kilograms = enter("Введiть кг: ");
            double tons = Lib.ConvertKilogramToTonne(kilograms);
            Console.WriteLine($"Вага у тонах: {tons}");
            Console.WriteLine();


        }
        
        public static double enter(string text)
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
