using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace lr0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 6.11:
            // Задаём переменные
            double a1 = 1;
            double a2 = 1;
            // Дополнительный комментарий
            // Через консоль задаём максимальчное число итераций
            Console.Write("Максимальное число итераций: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итерация номер 1:");
            // Задаём промежуточную переменную для того, чтобы менять a1 и a2 местами
            double a3 = 1.99 * a2 - a1;
            Console.WriteLine(a3);
            // Объявим номер итерации
            int num = 1;
            // Вводим логическую переменную condition
            bool condition = true;
            // Цикл продолжается до тех пор, пока a3 больше 0.9
            while (a3 >= 0.9)
            {
                num++;
                // На итерации m + 1 прекращаем выполнение цикла
                if (num == m + 1)
                {
                    num = num - 1;
                    Console.WriteLine("Выполнено " + num + " итерации, условие не выполнено.");
                    // В случае, когда максимальное число превышено, k принимает false
                    condition = false;
                    break;
                }
                else
                {
                    a1 = a2;
                    a2 = a3;
                    a3 = 1.99 * a2 - a1;
                    Console.WriteLine("Итерация номер " + num + ":");
                    Console.WriteLine(a3);
                }
            }
            // В случае, если максимальное число не превышено, k остаётся true, вследствие чего выводится соответствующее сообщение
            if (condition == true)
            {
                Console.WriteLine("Выполнено " + num + " итерации, условие выполнено.");
            }
            // Выводим количество выполненных итераций
            Console.Read();
        }
    }
}
