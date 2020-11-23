using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int menu, menu1 = 1;

            while (menu1 == 1) { 
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Что вы хотите сделать с числами?");
                Console.WriteLine("1 - Сложить");
                Console.WriteLine("2 - Вычесть");
                Console.WriteLine("3 - Умножить");
                Console.WriteLine("4 - Разделить");


                menu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ответ: ");
                if (menu == 1) Console.WriteLine(a + b);
                if (menu == 2) Console.WriteLine(a - b);
                if (menu == 3) Console.WriteLine(a * b);
                if (menu == 4) Console.WriteLine(a / b);

                Console.WriteLine(" ");
            }

        }
    }
}
