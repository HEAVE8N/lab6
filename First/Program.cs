using System;

namespace PracticeC_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Тест конструкторов базового класса
            TripleNumber tn1 = new TripleNumber();
            Console.WriteLine($"tn1 (по умолчанию): {tn1.ToString()}");

            TripleNumber tn2 = new TripleNumber(123, 456, -789);
            Console.WriteLine($"tn2: {tn2.ToString()}");
            Console.WriteLine($"Макс. последняя цифра в tn2: {tn2.MaxLastDigit()}");

            TripleNumber tn3 = new TripleNumber(tn2);
            Console.WriteLine($"tn3 (копия tn2): {tn3.ToString()}");

            // Тест с корректными значениями
            TriangleSides tr1 = new TriangleSides(3, 4, 5);
            Console.WriteLine(tr1.ToString());
            Console.WriteLine($"Периметр: {tr1.GetPerimeter()}");
            Console.WriteLine($"Можно ли построить: {tr1.IsValidTriangle()}");

            // Тест с некорректными значениями (конструктор исправит на 5,5,5)
            Console.WriteLine("\nСоздание с отрицательной стороной");
            TriangleSides tr2 = new TriangleSides(-2, 4, 5);
            Console.WriteLine(tr2.ToString());

            Console.WriteLine("\nЗамена параметра A на 1");
            tr2.A = 1;
            Console.WriteLine($"После изменения: {tr2.ToString()}");

            Console.WriteLine("\nЗамена параметра A на -1");
            tr2.A = -1;
            Console.WriteLine($"После изменения: {tr2.ToString()}");

            // Ручной ввод для базового класса
            TripleNumber handInpMain = InputTripleNumber();
            Console.WriteLine($"\nСоздан объект: {handInpMain.ToString()}");
            Console.WriteLine($"Максимальная последняя цифра: {handInpMain.MaxLastDigit()}");

            // Ручной ввод для треугольника
            TriangleSides handInpTr = InputTriangleSides();
            Console.WriteLine($"\n{handInpTr.ToString()}");

            if (handInpTr.IsValidTriangle())
            {
                Console.WriteLine($"Периметр: {handInpTr.GetPerimeter()}");
            }
        }

        private static int ReadInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
            }
        }

        private static int ReadPositiveInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                    continue;
                }

                if (result <= 0)
                {
                    Console.WriteLine("Ошибка: Число должно быть положительным (> 0)!");
                    continue;
                }

                return result;
            }
        }

        private static TripleNumber InputTripleNumber()
        {
            Console.WriteLine("\nВведите три целых числа:");
            int a = ReadInt("A = ");
            int b = ReadInt("B = ");
            int c = ReadInt("C = ");

            return new TripleNumber(a, b, c);
        }

        private static TriangleSides InputTriangleSides()
        {
            Console.WriteLine("\nВведите стороны треугольника (положительные числа):");
            int a = ReadPositiveInt("Сторона A = ");
            int b = ReadPositiveInt("Сторона B = ");
            int c = ReadPositiveInt("Сторона C = ");

            TriangleSides triangle = new TriangleSides(a, b, c);

            if (!triangle.IsValidTriangle())
            {
                Console.WriteLine("Предупреждение: Из введённых сторон нельзя построить треугольник!");
                Console.WriteLine("(Нарушено неравенство треугольника: сумма двух сторон должна быть больше третьей)");
            }

            return triangle;
        }
    }
}
