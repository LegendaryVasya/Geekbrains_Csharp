using System;

class ForStud
{
    static void Pause()
    {
        Console.WriteLine("Pause?");
        Thread.Sleep(10000);
        Console.WriteLine("Yeah");
    }

    static void Print(string name, string secname, int age)
    {
        Console.WriteLine($"Имя: {name} Фамилия: {secname} Возраст: {age}");
    }

    static void Main(string[] args)
    {
        Pause();
    }
}