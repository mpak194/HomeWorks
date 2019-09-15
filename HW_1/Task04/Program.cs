using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double u, r;
            string input_u, input_r;
            bool input = true;
            do
            {
                Console.WriteLine("**************\n" +
                    "Введите значение напряжения U:");
                input_u = Console.ReadLine();
                Console.WriteLine("Введите знчение сопротивления R:"); //ввод значений u и r
                input_r = Console.ReadLine();
                if (double.TryParse(input_u, out u) & double.TryParse(input_r, out r)) //проверка на приведение типа
                {
                    if (r <= 0 || u <= 0)
                    {
                        input = false;
                        Console.WriteLine("\a\n" +
                            "Вводимые значения не могут быть меньше или равны 0");
                    }
                    else
                    {
                        Console.WriteLine("\nСила тока I равна {0}",   // вывод ответа
                            (u / r).ToString("F3"));
                        Console.WriteLine("Потребляемая мощность P равна {0}", 
                            (u * u / r).ToString("F3"));
                    }
                }
                else
                {
                    input = false;
                    Console.WriteLine("Проверьте вводимые значения!!!");
                }
            

                bool restart = false;
                do
                {
                    Console.WriteLine("\nХотите продолжить работу?\n" +  //запрос на перезапуск программы
                        "Для перезапуска программы введите 1\n" +
                        "Для выхода введите 0\n");
                    string ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        restart = true;
                        input = false;
                    }
                    else if (ans == "0")
                    {
                        Console.WriteLine("Спасибо за работу");
                        input = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\aЯ не понимаю такой команды");
                    }
                } while (!restart);
            } while (!input);


            Console.ReadKey();
        }
    }
}
