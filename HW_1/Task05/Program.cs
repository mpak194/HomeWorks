using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double k1, k2;
            bool inp_value = true;
            bool restart = false;
            do //цикл для перезапуска программы
            {
                do //цикл для повторного ввода данных
                {
                    Console.WriteLine("Введите длины двух катетов");
                    Console.WriteLine("Длина первого катета:"); //ввод данных
                    string inp_k1 = Console.ReadLine();
                    Console.WriteLine("Длина второго катета:");
                    string inp_k2 = Console.ReadLine();
                    if (double.TryParse(inp_k1, out k1) & double.TryParse(inp_k2, out k2)) //проверка данных на приведение
                    {
                        if (k1 > 0 & k2 > 0) //проверка данных на диапазон
                        {
                            //вывод ответа
                            Console.WriteLine("Гипотенуза равна {0}", (Math.Sqrt(k1 * k1 + k2 * k2)).ToString("F3"));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\aДлины катетов не могут быть меньше или равны 0");
                            inp_value = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\aПроверьте вводимые данные!!!");
                        inp_value = false;
                    }
                } while (!inp_value);

                bool exit = true;
                do // цикл для выхода из программы
                {
                    Console.WriteLine("Хотите продолжить работу?\n" +
                    "Для перезапуска программы введите 1\n" +
                    "Для выхода - 0");
                    string ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        restart = true;
                        break;
                    }
                    else if (ans == "0")
                    {
                        Console.WriteLine("Спасибо за работу");
                        restart = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\aЯ не понимаю такой команды\n");
                        exit = false;
                    }
                } while (!exit);
            } while (restart);
            

            Console.ReadKey();
            
        }
    }
}
