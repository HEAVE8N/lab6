using System;

namespace PracticeC_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Тест конструкторов
            Console.WriteLine("1. ТЕСТ КОНСТРУКТОРОВ:");
            LineSegment ls1 = new LineSegment();
            Console.WriteLine($"   По умолчанию: {ls1.ToString()}");

            LineSegment ls2 = new LineSegment(2, 3, 5, 7);
            Console.WriteLine($"   С параметрами: {ls2.ToString()}");

            LineSegment ls3 = new LineSegment(ls2);
            Console.WriteLine($"   Копирование: {ls3.ToString()}");

            // Тест метода Contains
            Console.WriteLine("\n2. ТЕСТ Contains:");
            Console.WriteLine($"   Отрезок ls2: {ls2.ToString()}");
            Console.WriteLine($"   Число 3 попадает в отрезок по X? {ls2.Contains(3)}");
            Console.WriteLine($"   Число 10 попадает в отрезок по X? {ls2.Contains(10)}");

            // Тест унарных операторов
            Console.WriteLine("\n3. ТЕСТ УНАРНЫХ ОПЕРАТОРОВ:");
            Console.WriteLine($"   Длина ls2 (!ls2) = {(!ls2):F2}");

            LineSegment ls4 = new LineSegment(1, 1, 3, 3);
            Console.WriteLine($"   До ++: {ls4.ToString()}");
            ls4++;
            Console.WriteLine($"   После ++: {ls4.ToString()}");

            // Тест приведения типов
            Console.WriteLine("\n4. ТЕСТ ПРИВЕДЕНИЯ ТИПОВ:");
            LineSegment ls5 = new LineSegment(3.7, 5.9, 8.2, 10.4);
            Console.WriteLine($"   Отрезок: {ls5.ToString()}");
            Console.WriteLine($"   (int)ls5 = {(int)ls5} (целая часть X1)");
            Console.WriteLine($"   (double)ls5 = {(double)ls5} (координата Y1)");

            // Тест бинарных операторов
            Console.WriteLine("\n5. ТЕСТ БИНАРНЫХ ОПЕРАТОРОВ:");
            LineSegment ls6 = new LineSegment(1, 2, 4, 5);
            Console.WriteLine($"   Исходный: {ls6.ToString()}");
            Console.WriteLine($"   ls6 + 10 = {(ls6 + 10).ToString()}");
            Console.WriteLine($"   5 + ls6 = {(5 + ls6).ToString()}");

            // Тест операторов сравнения
            Console.WriteLine("\n6. ТЕСТ ОПЕРАТОРОВ СРАВНЕНИЯ:");
            LineSegment ls7 = new LineSegment(2, 0, 8, 0);
            Console.WriteLine($"   Отрезок: {ls7.ToString()}");
            Console.WriteLine($"   ls7 < 5 = {ls7 < 5}");
            Console.WriteLine($"   ls7 > 10 = {ls7 > 10}");

            // Ручной ввод
            Console.WriteLine("\n=== РУЧНОЙ ВВОД ===");
            LineSegment manualLs = InputLineSegment();

            Console.WriteLine($"\nСоздан отрезок: {manualLs.ToString()}");
            Console.WriteLine($"Длина отрезка: {(!manualLs):F2}");
            Console.WriteLine($"(int)отрезок = {(int)manualLs}");
            Console.WriteLine($"(double)отрезок = {(double)manualLs}");

            Console.Write("\nВведите число для проверки попадания в отрезок по X: ");
            double checkValue = ReadDouble("Число: ");
            Console.WriteLine($"Число {checkValue} попадает в отрезок? {manualLs.Contains(checkValue)}");
        }

        private static double ReadDouble(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите число!");
                }
            }
        }

        private static LineSegment InputLineSegment()
        {
            Console.WriteLine("\nВведите координаты отрезка:");

            double x1 = ReadDouble("X1 = ");
            double y1 = ReadDouble("Y1 = ");
            double x2 = ReadDouble("X2 = ");
            double y2 = ReadDouble("Y2 = ");

            return new LineSegment(x1, y1, x2, y2);
        }
    }
}
