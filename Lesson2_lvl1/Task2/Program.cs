// Задание 2
// Написать метод подсчета количества цифр числа.



using System;

class Program
{

    static void Count(string a)
    {
        Console.WriteLine("Количество цифр в числе {0} = {1}",a ,a.Length);
    }
    static void Main(string[] args)
    {
        string aa = Console.ReadLine();
        Count(aa);   
    }
}