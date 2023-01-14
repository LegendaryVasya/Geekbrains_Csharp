// Задание 4
//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
//выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
//    GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
//    вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
//цикла do while ограничить ввод пароля тремя попытками.



class Program
{
    public static int attemp = 0;
    static bool Check(string login, string pass)
    {
        
        string TrueLogin = "admin";
        string TruePass = "GeekBrains";
        if (login == TrueLogin)
        {
            if (pass == TruePass)
            {
                attemp = 3;
                return true;
                
            }
            else
            {
                attemp = attemp + 1;
                return false;
            }
        }
        else
        {
            attemp = attemp + 1;
            return false;
        }
    }
    static void Main(string[] arg)
    {
        bool c;
        string l;
        string p;
        do 
        {
            l = Console.ReadLine();
            p = Console.ReadLine();
            c = Check(l,p);
            if (c == true)
            {
                Console.Write("You inside");
                break;
            }
            else
            {
                Console.WriteLine("Вы истратили {0} попытку ввода из 3", attemp);
            }
        } while (attemp != 3);

    }

}