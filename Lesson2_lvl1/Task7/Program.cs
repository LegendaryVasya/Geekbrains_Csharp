// Задание 7
// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

class Program
{
    static void Loop(int a, int b)
    {
        Console.Write("{0} ",a);
        if (a < b) Loop(a+1, b);
    }

    static int Sum(int a, int b)
    {

        if (a < b)
            return a + Sum(a + 1, b);
        else
            return a;

    }
    static void Main(string[] args)
    {
        Loop(1, 10);
        int s =  Sum(1, 10);
        Console.WriteLine("Cумма чисел: {0}", s);
    }
}