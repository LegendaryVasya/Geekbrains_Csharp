// Задание 3
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
// положительных чисел.


class Program
{
    static void Main(string[] args)
    {
        int ar = 0;
        int a = Convert.ToInt32(Console.ReadLine());
        while (a != 0)
        {
            a = Convert.ToInt32(Console.ReadLine());
            ar = ar + a;
        }
        Console.WriteLine(ar);
    }
}