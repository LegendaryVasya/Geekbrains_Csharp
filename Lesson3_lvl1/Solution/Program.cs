using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    class Task1 // Complex
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    //    Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    {
        double im = 0;
        double re = 0;
        public Task1()
        {
            im = 0;
            re = 0;
        }
        public Task1(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        // Метод сложения комплексных чисел
        public Task1 Plus(Task1 x2)
        {
            Task1 x3 = new Task1();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        // Метод вычитания комплексных чисел
        public Task1 Minus(Task1 x2)
        {
            Task1 x3 = new Task1();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        // Метод произведения комплексных чисел
        public Task1 Multipli(Task1 x2)
        {
            Task1 x3 = new Task1();
            x3.im = x2.re * im + x2.im * re;
            x3.re = x2.re * re + (x2.im * im * (-1));
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
            // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }

    class Task2
    {
        //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
        //вывести на экран, используя tryParse.

        static int sum = 0;
        static int Sum(int num)
        { 
            sum = sum + num;
            return sum;
        } 
        public Task2()
        {
            int s = 0;
            while (true)
            {
                bool result = int.TryParse(Console.ReadLine(), out var number);
                if (result)
                {
                    
                    if (number != 0)
                    {
                        s = Sum(number);
                        
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод:\n ");
                }
            }
            if (s != 0) Console.WriteLine(s);
        }
    }

    class Task3
    {
    //* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
    // программу, демонстрирующую все разработанные элементы класса.
    //* Добавить свойства типа int для доступа к числителю и знаменателю;
    //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //ArgumentException("Знаменатель не может быть равен 0");
    //*** Добавить упрощение дробей.

    struct Fraction
    {
        public int numerator; 
        public int denominator;
    }

    static bool Fraction_Addition(Fraction A, Fraction B)
    {
        if (A.denominator == B.denominator)
        {
            int s1 = A.numerator + B.numerator;
            int s2 = A.denominator;
            Console.WriteLine($"Ввша первая дробь {A.numerator}/{A.denominator}, вторая {B.numerator}/{B.denominator}");
            Console.WriteLine("Сумма дробей равна {0}/{1}",s1,s2);
            return false;
        }
        else
        {
            Console.WriteLine("При сложении двух дробей, знаменатели должны быть равны");
            return true;
        }
    }

    static bool Subtraction_Fraction(Fraction A, Fraction B) 
    {
        if (A.denominator == B.denominator)
        {
            if (A.numerator > B.numerator)
            {
                int s1 = A.numerator - B.numerator;
                int s2 = A.denominator;
                Console.WriteLine($"Ввша первая дробь {A.numerator}/{A.denominator}, вторая {B.numerator}/{B.denominator}");
                Console.WriteLine("Разность дробей равна {0}/{1}",s1,s2);
                return false;
            }
            else
            {
                int s1 = B.numerator - A.numerator;
                int s2 = A.denominator;
                Console.WriteLine($"Ввша первая дробь {A.numerator}/{A.denominator}, вторая {B.numerator}/{B.denominator}");
                Console.WriteLine("Разность дробей равна {0}/{1}",s1,s2);
                return false;
            }

        }
        else
        {
            Console.WriteLine("При вычитании, знаменатели должны быть равны");
            return true;
        }
    }

        static bool Multiplication_Fraction(Fraction A, Fraction B)
        {
            int s1 = A.numerator * B.numerator;
            int s2 = A.denominator * B.denominator;
            Console.WriteLine($"Ввша первая дробь {A.numerator}/{A.denominator}, вторая {B.numerator}/{B.denominator}");
            Console.WriteLine("Произведение дробей равна {0}/{1}",s1,s2);
            return false;
        }

        static bool Division_Fraction(Fraction A, Fraction B)
        {
            int s1 = A.numerator * B.denominator;
            int s2 = A.denominator * B.numerator;
            Console.WriteLine($"Ввша первая дробь {A.numerator}/{A.denominator}, вторая {B.numerator}/{B.denominator}");
            Console.WriteLine("Произведение дробей равна {0}/{1}",s1,s2);
            return false;
        }

        static bool Check(Fraction A, Fraction B)
        {
            if ((A.denominator) == 0 & (B.denominator) == 0)
            {
                Console.WriteLine("Знаменатель не должен равняться 0");
                return true;
            }
            else
            {
                return false;
            }
        }
        public Task3()
    {
        bool state = true;
        bool check = true; 
        Fraction A, B;
        A.numerator = 0;
        A.denominator = 0;
        B.numerator = 0;
        B.denominator = 0;
        while (state)
        {
            
        
        Console.WriteLine("Введите поочередно числитель и знаменатель дроби 1");
        A.numerator = Convert.ToInt32(Console.ReadLine());
        while (check)
        {
            A.denominator = Convert.ToInt32(Console.ReadLine());
            if (A.denominator == 0)
            {
                Console.WriteLine("Знаменатель не должен равняться 0");
                Console.WriteLine("Введите его еще раз");
                check = true;
            }
            else
            {
                check = false;
            }
        }
        check = true;
        Console.WriteLine("Введите поочередно числитель и знаменатель дроби 2");
        B.numerator = Convert.ToInt32(Console.ReadLine());
        while (check)
        {
            B.denominator = Convert.ToInt32(Console.ReadLine());
            if (B.denominator == 0)
            {
                Console.WriteLine("Знаменатель не должен равняться 0");
                Console.WriteLine("Введите его еще раз");
                check = true;
            }
            else
            {
                check = false;
            }
        }

        

        

        Console.WriteLine("Какое действие вы хотетие совершить над дробями?\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление");
        string action = Console.ReadLine();
        switch (action)
        {
            case "1":
                state = Fraction_Addition(A, B);
                break;
            case "2":
                state = Subtraction_Fraction(A, B);
                break;
            case "3":
                state = Multiplication_Fraction(A, B);
                break;
            case "4":
                state = Division_Fraction(A, B);
                break;


        }
        }
    }

    }

  
    static void Main(string[] args)
    {
        // Task1...................................................................................................................
        
        //// Описали ссылку на объект.
        //Task1 complex1;
        //// Создали объект и сохранили ссылку на него в complex1.
        //complex1 = new Task1(1, 1);
        //// Описали объект и создали его.
        //Task1 complex2 = new Task1(2, 2);
        //// С помощью свойства Im изменили внутреннее (приватное) поле im.
        //complex2.Im = 3;
        //// Создали ссылку на объект.
        //Task1 result;
        

        //Console.WriteLine("Какое действие вы хотите произвести над комплексными числами: ");
        //Console.WriteLine("Список возмодных действий:\nСложить\nВычисть\nУмножить\n\nНапишите пожалуйста");
        //string action =  Console.ReadLine();

        //switch (action)
        //{
        //    case "Сложить":
        //        // Так как в методе Plus создается новый объект,
        //        // в result сохраняем ссылку на вновь созданный объект.
        //        Console.WriteLine(complex1.ToString());
        //        Console.WriteLine(complex2.ToString());
        //        result = complex1.Plus(complex2);
        //        Console.WriteLine(result.ToString());
        //        break;
        //    case "Вычисть":
        //        Console.WriteLine(complex1.ToString());
        //        Console.WriteLine(complex2.ToString());
        //        result = complex1.Minus(complex2);
        //        Console.WriteLine(result.ToString());
        //        break;
        //    case "Умножить":
        //        Console.WriteLine(complex1.ToString());
        //        Console.WriteLine(complex2.ToString());
        //        result = complex1.Multipli(complex2);
        //        Console.WriteLine(result.ToString());
        //        break;
        //}

        //...................................................................................................................

        //Task2..............................................................................................................
        //Task2 p2 = new Task2();
        //...................................................................................................................

        //Task3...............................................................................................................
        Task3 p3 = new Task3();
    }
}