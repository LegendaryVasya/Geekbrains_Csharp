//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа меняет значения местами: ");
        Console.WriteLine("Введите значение a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение b");
        int b = Convert.ToInt32(Console.ReadLine());
        int t = a; 
        Console.WriteLine($"a = {a=b}");
        Console.WriteLine($"b = {b = t}");
    }
}