using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prog = true;
            while (prog) //цикл для возможности перезапуска программы
            {
                bool input = true;
                int Code = 0;
                while (input) //цикл для повторного ввода данных
                {
                    //ввод значений и проверка на приведение и нужный диапазон допустимых значений
                    Console.WriteLine("Введите число от 32 до 127: ");
                    if (int.TryParse(Console.ReadLine(), out Code) && (Code >= 32 && Code <= 127))
                        break;
                    else
                        Console.WriteLine("Проверьте вводимые данные!!!");
                }
                char Code_ch = (char)Code;
                Console.WriteLine("Значение {0} в ASCII: {1}", Code, Code_ch); //вывод ответа
                bool exit = false;
                while (!exit) //цикл для выхода из программы

                {
                    Console.WriteLine("Хотите ли вы продолжить работу? \nВведите 1 для перезапуска, 0 - для выхода ");
                    string ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        prog = true;
                        break;
                    }
                        
                    if (ans == "0")
                    {
                        Console.WriteLine("Спасибо за работу");
                        prog = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Я не понимаю такой команды, попробуйте снова");
                    }
                }
                
            }
            
            Console.ReadKey();
            
            
        }
    }
}
