using System;

namespace Zadanie_iskluchenie
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добро пожаловать в калькулятор!");
                Console.WriteLine("Введите первое число, затем нажите Enter");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число, затем нажите Enter");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции (1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное, 5 - деление), затем нажите Enter");
                int c = Convert.ToInt32(Console.ReadLine());
                double otvet;
                switch (c)
                {
                    case 1:
                        {
                            otvet = a + b;
                            Console.WriteLine("Результат равен {0:f2}", otvet);
                            break;
                        }
                    case 2:
                        {
                            otvet = a - b;
                            Console.WriteLine("Результат равен {0:f2}", otvet);
                            break;
                        }
                    case 3:
                        {
                            otvet = a * b;
                            Console.WriteLine("Результат равен {0:f2}", otvet);
                            break;
                        }
                    case 4:
                        {
                            otvet = a % b;
                            Console.WriteLine("Результат равен {0:f2}", otvet);
                            break;
                        }
                    case 5:
                        {
                            otvet = a / b;
                            Console.WriteLine("Результат равен {0:f2}", otvet);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет оперпции с указанным номером");
                            break;
                        }

                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
  
     


           

