// Задание 6
//// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
//000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
//    подсчёт времени выполнения программы, используя структуру DateTime.

using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        DateTime start=DateTime.Now;
        int goodnumcount = 0;
        int minnum = 1;
        int maxnum = 1000000;
        int temp;
        int testnum;

        for (int num = minnum; num <= maxnum; num++)
        {
            temp = 0;
            testnum = num;
            while (testnum != 0)
            {
                temp += testnum % 10;
                testnum /= 10;
            }
            Console.WriteLine(num);
            Console.WriteLine(temp);
            if (num % temp == 0) goodnumcount++;
           
        }
        Console.WriteLine("Хороших чисел в промежутке от 1 до 1000000: {0}", goodnumcount);
        DateTime finish=DateTime.Now;
        Console.WriteLine("Время выполнения программы {0}", finish-start);
    }

}