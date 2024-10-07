using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //task 1
                Console.WriteLine("Завдання 1");
                Console.WriteLine("Вести значення a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввести значення n:");
                int n = Convert.ToInt32(Console.ReadLine());
                double sum = 0;
                int i = 0;
                while (i <= n)
                {
                    sum += Math.Pow(-a, i);
                    i++;
                }
                Console.WriteLine($"s={sum}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            {  //task 2

                Console.WriteLine("Завдання 2");
                double x = 1.5;
                double epsilon = Math.Pow(10, -2);

                double sum = 0;
                double current;
                int n = 1;
                int iteration = 0;
                do
                {
                    current = Math.Pow(-1, n) * (n + 1) / (Math.Pow((n * x), 2) + 1);
                    sum += current;
                    Console.WriteLine($"Ітерація {iteration + 1}: Поточний член = {current}, Накопичена сума = {sum}, Похибка = {Math.Abs(current / sum)}");
                    n++;
                    iteration++;
                } while (Math.Abs(current) >= epsilon);
                Console.WriteLine($"\nОстаточна сума ряду: {sum}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            {  //task 3
                Console.WriteLine("Завдання 3");
                double a = 4.5;
                double b = 18.5;
                double h = 0.4;

                Console.WriteLine(" x \t tg(√x) \t x / (x - 3)^2");
                Console.WriteLine("-------------------------------------");

                for (double x = a; x <= b; x += h)
                {
                    double y = Math.Tan(Math.Sqrt(x));
                    double z = x / Math.Pow((x - 3), 2);

                    Console.WriteLine($"{x:F2} \t {y:F4} \t {z:F4}");
                }
            }


        }
    }
}
