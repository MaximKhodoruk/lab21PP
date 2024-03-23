using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа № 21");
            int a = 0;
            int b = 0;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите действие:\n1 - ввести А\n2 - ввести В\n3 - выполнить операцию +\n4 - выполнить операцию -\n5 - выполнить операцию *\n6 - выполнить операцию /\n7 - закончить программу");
                int sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Введите А");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Введите В");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine(a + b);
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine(a - b);
                            Console.WriteLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine(a * b);
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine();
                            Console.WriteLine(a / b);
                            Console.WriteLine();
                            break;
                        }
                    case 7:
                        {
                            exit = true;
                            break;
                        }
                }
            }
        }
    }
}
