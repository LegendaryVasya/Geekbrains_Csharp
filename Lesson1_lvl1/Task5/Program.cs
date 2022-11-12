//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//    б) *Сделать задание, только вывод организовать в центре экрана.
//    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int
//    x,int y).

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите свое имя:");
//        string name = Console.ReadLine();
//        Console.WriteLine("Введите свое фамилия:");
//        string secname = Console.ReadLine();
//        Console.WriteLine("Введите свое город проживания:");
//        string location = Console.ReadLine();
//        string s = name + " " + secname + " " + location;
//        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
//        Console.WriteLine(s);
//    }
//}

using System;

class Program
{

    static void Print(string msg)
    {
        Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
        Console.WriteLine(msg);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите свое фамилия:");
        string secname = Console.ReadLine();
        Console.WriteLine("Введите свое город проживания:");
        string location = Console.ReadLine();
        string s = name + " " + secname + " " + location;
        Print(s);
    }
}