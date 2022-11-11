//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//    y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
//    используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
//метода.

//using System;

//class range
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Эта программа находит расстояние между точками с соответсвующими координатами" );
//        Console.WriteLine("Введите x1, y1: ");
//        int x1 = Convert.ToInt32(Console.ReadLine());
//        int y1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите x2, y2: ");
//        int x2 = Convert.ToInt32(Console.ReadLine()); 
//        int y2 = Convert.ToInt32(Console.ReadLine());
//        Console.Write($"r = {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
//    }
//}


using System;

class range
{
    static double r(int x1, int y1, int x2, int y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Эта программа находит расстояние между точками с соответсвующими координатами" );
        Console.WriteLine("Введите x1, y1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите x2, y2: ");
        int x2 = Convert.ToInt32(Console.ReadLine()); 
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("r = {0}",r(x1,y1,x2,y2));
    }
}

