//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,рост, вес).
//В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

using System;

class Anketa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вас приветствует программа \'Анкета\'");
        Console.Write("Введите свое имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите свою фамилию: ");
        string surname = Console.ReadLine();
        Console.Write("Введите свой возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите свой рост: ");
        float growth = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите свой вес: ");
        float weight = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine(name + " " + surname + " " + age + " " + growth + " " + weight);
        Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, growth, weight);
        Console.Write($"{name} {surname} {age} {growth} {weight}");
    }
}