using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ №1
            double a = 16.80;
            double b = 12.40;
            double result = Math.Sqrt(a) * Math.Sqrt(b);
            Console.WriteLine($" ДЗ №1  Result: {result}");

            // ДЗ №2
            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            double AC = A - C;
            double BC = B * (-1) + C;
            double resultat = AC + BC;
            Console.WriteLine($" ДЗ №2  Result:{resultat}");

            // ДЗ №3
            double x1 = -6.2;
            double y1 = 5.2;
            double x2 = 2.10;
            double y2 = 9.8;
            double resul = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"ДЗ №3   Result: {resul}");

            // ДЗ №4
            int d;
            Console.WriteLine("Ввод двузначного числа");
            d = Convert.ToInt32(Console.ReadLine());
            int s = d / 10;
            int o = d % 10;
            Console.WriteLine($"ДЗ №4  Result {o * 10 + s}");

            // ДЗ №5
            int N = 10985;
            int Res = N / 60;
            Console.WriteLine($"ДЗ №5: {Res}");

            // ДЗ №6
            int den;
            Console.WriteLine("Введите номер дня");
            den = Convert.ToInt32(Console.ReadLine());
            int y = den % 7;
            
            Console.WriteLine($"ДЗ №6    День недели: {y}"); 
            // 0 — воскресенье, 1 — понедельник, 2 — вторник, …, 6 — суббота

            

        }
    }
}
