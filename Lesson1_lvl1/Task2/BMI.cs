//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
//I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

using System;

class BMI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Расчет индекса массы тела");
        Console.Write("Введите свой вес: ");
        float weight = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите свой рост: ");
        float growth = Convert.ToSingle(Console.ReadLine());
        Console.Write($"Ваш  индекс = {weight / (growth * growth)}");
    }
}