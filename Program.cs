using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАЧА 1. Решение квадратного уравнения

            //ввод коэффициентов уравнения
            Console.Write("Введите коэффициент а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            //проверяем введенные данные - рассматриваем некоторые частные случаи
            if(a==0 && b==0 && c == 0) Console.WriteLine("Нечего решать! Введите хотя бы один коэффициент, отличный от ноля");
            
            while (a == 0) { 
                Console.WriteLine("Уравнение не является квадратным, введите  коэффициент а, отличный от ноля: ");
                a = Convert.ToDouble(Console.ReadLine());
            }

            double x = 0;
            double x1 = 0 , x2 = 0;
            if (b == 0 && c==0) {
                Console.WriteLine($"Предстоит решить уравнение: \n {a} * x^2 = 0");
                Console.WriteLine("Ответ: x = 0");
            }
            if (b==0 && c!=0)
            {
                Console.WriteLine($"Предстоит решить уравнение: \n {a} * x^2  + ({c})= 0");
                if (-c / a < 0)
                    Console.WriteLine("Уравнение не имеет корней");
                else
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = -Math.Sqrt(-c / a);
                    Console.WriteLine($"Ответ: x1 = {x1} и x2 = {x2}");
                }
            }
            if (b!=0 && c == 0)
            {
                Console.WriteLine($"Предстоит решить уравнение: \n {a} * x^2  + ({b}) * x = 0");
                x1 = 0;
                x2 = -b / a;
                Console.WriteLine($"Ответ: x1 = {x1} и x2 = {x2}");
            }

            //Ищем дискриминант и решаем уравнение согласно его значению
            if (a != 0 && b != 0 && c != 0)
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine($"Дискриминант {d} меньше 0 , уравнение не имеет действительных корней");
                }
                if (d == 0)
                {
                    Console.WriteLine($"Дискриминант {d} , уравнение имеет один корень");
                    x = -b / 2 * a;
                    Console.WriteLine($"Ответ: х = {x}");
                }
                if(d>0)
                {
                    Console.WriteLine($"Дискриминант {d} больше 0, уравнение имеет два различных корня");
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"Ответ: х1 = {x1} и x2 = {x2}");
                }
            }
        }
    }
}
