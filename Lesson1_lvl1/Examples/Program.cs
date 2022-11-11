////Практическая часть урока.
////Задача 1. Написать программу сложения двух чисел.

//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double x;
//        double y;
//        Console.Write("Введите первое число: ");
//        string str = Console.ReadLine();
//        x = Convert.ToDouble(str);
//        Console.Write("Введите второе число: ");
//        y = Convert.ToDouble(Console.ReadLine());
//        double z = x + y;
//        Console.WriteLine(x + "+" + y + "=" + z); // Преобразование в строку
//        //Console.ReadLine();
//    }
//}

////Задача 2. Вывести значение функции ax^2+bx+c в точке x. x — ввести с
////клавиатуры, a,b и c — присвоить в программе.


//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double a = 1;
//        double b = 1;
//        double c = 1;
//        double x;
//        Console.Write("Введите значение x: ");
//        string s = Console.ReadLine();
//        x = Convert.ToDouble(s);
//        double f = a*Math.Pow(x, 2) + b * x + c;
//        Console.WriteLine("{0}*x^2+{1}*x+{2}, при x={3}, f={4}", a, b, c, x,
//            f);
//        //Console.ReadLine();
//    }
//}


//// Задача 3. Обменять значениями две переменные.

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите значение a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите значение b: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        int t = a;
//        //int a=10; // Присваиваем начальное значение
//        //int b=20; // Присваиваем начальное значение
//        //int t=a; // В t запоминаем значение a
//        a=b; // В a записываем b
//        b=t; // В b записываем сохраненное a
//        Console.WriteLine("Значение a = {0} и значение b = {1}", a,b);
//    }
//}


////Задача 4. Разработать метод проверки чётности числа. Метод возвращает true,
////если число чётное, и false, если число нечётное.

//using System;
//class Program
//{
//    static bool Odd(int n)
//    {
//        return n%2==0;
//    }
//    static void Main(string[] args)
//    {
//        //int value = 100500;
//        Console.WriteLine("Введи значение");
//        int value = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine(Odd(value));
//    }
//}


////Задача 5. Работа с консолью и перегрузкой методов.

//using System;
//class Program
//{
//    static void Print(string msg, int x, int y)
//    {
//// Установим позицию курсора на экране
//        Console.SetCursorPosition(x, y);
//        Console.WriteLine(msg);
//    }
//    static void Print(string msg, ConsoleColor foregroundcolor)
//    {
//        // Установим цвет символов
//        Console.ForegroundColor = foregroundcolor;
//        Console.WriteLine(msg);
//    }
//// Создайте перегрузку функции, в которой будет указана позиция и цвет
//    static void Main()
//    {
//        Print("Привет!\n", 10,10);
//        Print("Привет еще раз!", ConsoleColor.Red);
//        //Console.ReadLine();
//    }
//}

//Задача 6. Написать программу для подсчета площади треугольника.

using System;
class Program
{
    static bool IsTriangle (double a,double b,double c)
    {
        return a + b > c && a + c > b && c + b > a;
    }
    static double S(double a,double b,double c)
    {
        double p=(a+b+c)/2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static void Main(string[] args)
    {
        Console.Write("Введите a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle (a, b, c));
        Console.WriteLine("Площадь треугольника:" + S(a, b, c));
        //Console.ReadLine();
    }
}
