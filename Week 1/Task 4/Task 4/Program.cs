using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим число
            int n = int.Parse(Console.ReadLine());
            // Создаем два цикла где итератор второго цикла не может превышать итератор первого цикла
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    // Пока второй цикл работает мы выводим звездочку в один ряд
                    Console.Write("[*]");
                }
                // Когда второй цикл заканчивается мы переносим следующую звездочкуна следующую строку
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
