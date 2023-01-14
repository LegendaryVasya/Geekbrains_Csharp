
// Задание 1
// Написать метод, возвращающий минимальное из трёх чисел.



using System;


class Program
{
    static void Min(int a, int b, int c)
    {
        if ((a > b) & (a > c))
        {
            Console.Write("Наибольшее значение из {0}, {1}, {2} это {0}", a, b, c);
        }
        if ((b > a) & (b > c))
        {
            Console.Write("Наибольшее значение из {0}, {1}, {2} это {1}", a, b, c);
        }
        else
        {
            Console.Write("Наибольшее значение из {0}, {1}, {2} это {2}", a, b, c);
        }
    }

    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Min(a, b, c);
    }
}

