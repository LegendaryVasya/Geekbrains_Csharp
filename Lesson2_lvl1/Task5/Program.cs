// Задача 5
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
// массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса

using System.Linq.Expressions;

class Program
{

    static double BMI(float mass, float height)
    {
        double i = mass / (Math.Pow(height, 2));
        return i;
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Введите вес человека в кг");
        float m = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введите рост человека в метрах");
        float h = Convert.ToSingle(Console.ReadLine());
        double bmi = BMI(m,h);

        Console.WriteLine("Ваш индекс");
        Console.WriteLine(bmi);


        if ((bmi < 25) & (bmi > 18))
        {
            Console.WriteLine("Норма");
        }

        if ((bmi > 25) & (bmi < 29))
        {
            Console.WriteLine("Избыточный");
        }

        
        if ((bmi < 18))
        {
            float temp_m = m;
            Console.WriteLine("Недовес");
            while (bmi < 18)
            {
                m = m + 1;
                bmi = BMI(m, h);
            }

            float GAP = m - temp_m;
            Console.WriteLine("До нормы вам не обходимо набрать {0} КГ", GAP);
            Console.WriteLine("Тогда ваш BMI будет {0}", bmi);
            
        }


        if (bmi >= 30)
        {
            float temp_m = m;
            Console.WriteLine("Ожирение");
            while (bmi > 25)
            {
                m = m - 1;
                bmi = BMI(m, h);
            }

            float GAP = temp_m - m;
            Console.WriteLine("До нормы вам не обходимо сбросить {0} КГ", GAP);
            Console.WriteLine("Тогда ваш BMI будет {0}", bmi);
        }

 
    }

}