using System.Security.Cryptography;

namespace La
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            float a;
            float b;
            float c;
            float x1;
            float x2;
            float D;
            char endOrNext;


            Console.WriteLine("ax^2 + bx + c = 0 - Стандартное квадратное уравнение");

            Console.WriteLine("Нажмите - n для продолжения");
            Console.WriteLine("Нажмите - e для окончания");

            endOrNext = Convert.ToChar(Console.ReadLine());

            while (endOrNext == 'n')
            {
                Console.WriteLine("Введите a");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Введите c");
                c = Convert.ToSingle(Console.ReadLine());

                if (b == 0 && c != 0 && a != 0)
                {

                    x1 = (-c / a);

                    if (x1 >= 0)
                    {
                        Console.WriteLine("x = √(c : a)");
                        Console.WriteLine("x = -√(c : a)");
                        Console.WriteLine($"x = √{x1}");
                        Console.WriteLine($"x = -√{x1}");
                    }
                    else
                    {
                        Console.WriteLine("Корней нет");
                    }
                }
                else if (c == 0 && b != 0 && a != 0)
                {
                    Console.WriteLine($"x(ax + b) = 0");
                    Console.WriteLine($"x({a}x + {b}) = 0");
                    x1 = (-b / a);
                    Console.WriteLine($"x = 0 или ax + c = 0");
                    Console.WriteLine($"          {a}x + {b} = 0");
                    Console.WriteLine($"          {a}x = {-b}");
                    Console.WriteLine($"          x = {x1}");
                }
                else if (b == 0 && c == 0 && a != 0)
                {
                    Console.WriteLine("x = 0");
                }
                else if (a != 0 && b != 0 && c != 0)
                {
                    D = b * b - 4 * a * c;
                    Console.WriteLine($"Дискриминант = {D}");
                    if (D < 0)
                    {
                        Console.WriteLine("Корней нет");
                    }
                    else if (D == 0)
                    {
                        Console.WriteLine("x = -b : 2 * a");
                        Console.WriteLine($"x = -{b} : 2 * {a}");
                        x1 = -b / (2 * c);
                        Console.WriteLine($"x = {x1}");
                    }
                    else if (D > 0)
                    {
                        Console.WriteLine("x1 = -b + √D : 2 * a");
                        Console.WriteLine($"x1 = -{b} + √{D} : 2 * {a}");
                        Console.WriteLine("x2 = -b - √D : 2 * a");
                        Console.WriteLine($"x2 = -{b} - √{D} : 2 * {a}");
                        x1 = (-b + Convert.ToSingle(Math.Sqrt(D))) / (2 * a);
                        x2 = (-b - Convert.ToSingle(Math.Sqrt(D))) / (2 * a);
                        Console.WriteLine($"x1 = {x1}");
                        Console.WriteLine($"x2 = {x2}");
                    }
                }
                else if (a == 0)
                {
                    Console.WriteLine("Вы ввели обычное уравнение, решай сам)");
                }
                else
                {
                    Console.WriteLine("Вы ввели парашу (");
                }
                Console.WriteLine("Нажмите - n для продолжения");
                Console.WriteLine("Нажмите - e для окончания");

                endOrNext = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}