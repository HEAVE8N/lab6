using System;

namespace PracticeC_
{
    internal class TriangleSides : TripleNumber
    {
        public TriangleSides() : base()
        {
        }

        public TriangleSides(int sideA, int sideB, int sideC) : base(sideA, sideB, sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Предупреждение: Стороны должны быть > 0. Установлены значения по умолчанию (5, 5, 5).");
                A = 5;
                B = 5;
                C = 5;
            }
        }

        public new int A
        {
            get { return base.A; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка: Сторона A не может быть <= 0. Значение не изменено.");
                }
                else
                {
                    base.A = value;
                }
            }
        }

        public new int B
        {
            get { return base.B; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка: Сторона B не может быть <= 0. Значение не изменено.");
                }
                else
                {
                    base.B = value;
                }
            }
        }
        public new int C
        {
            get { return base.C; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка: Сторона C не может быть <= 0. Значение не изменено.");
                }
                else
                {
                    base.C = value;
                }
            }
        }

        public bool IsValidTriangle()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                return false;
            }

            return (A + B > C) && (A + C > B) && (B + C > A);
        }

        public int GetPerimeter()
        {
            if (!IsValidTriangle())
            {
                Console.WriteLine("Ошибка: Нельзя вычислить периметр — треугольник невалиден.");
                return 0;
            }

            return A + B + C;
        }

        public string GetTriangleType()
        {
            if (!IsValidTriangle())
            {
                return "Не треугольник";
            }

            if (A == B && B == C)
            {
                return "Равносторонний";
            }

            if (A == B || B == C || A == C)
            {
                return "Равнобедренный";
            }

            return "Разносторонний";
        }

        public override string ToString()
        {
            return $"Стороны: {base.ToString()}. Тип: {GetTriangleType()}";
        }
    }
}