using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        // Создаем функцию проверяющую на то что является ли число простым
        static bool prime(int k)
        {
            // Так как 1 не является простым числом пишем  return false
            if (k == 1) return false;
            // Пробегаемся по массиву для поиска простых чисел
            // Пишем i <= Math.Sqrt(k) дял того чтобы быстрей пробежатся по числам
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        { 
            // Создаем n для определения велечины массива
            // После чего парсим его
            int n = int.Parse(Console.ReadLine());
            // Вводим числа которые будут в массиве
            // И делим числа через пробелы
            string[] s = Console.ReadLine().Split();
            // Создание массива для чисел длинной n
            int[] arr = new int[n];
            // Создаем int cnt для дальнейшего считывания количества наших простых чисел
            int cnt = 0;
            // Создали массив для добавление в него простых чисел
            int[] pr = new int[n];
            // Для быстрого перевода нашей строки в тип int создаем for
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            // j будет нашим иттератором для массива простых чисел
            int j = 0;
            // Тут мы создаем for для проверки нашей функций
            for(int i = 0; i < n; i++)
            {
                if(prime(arr[i])==true)
                {
                    pr[j] = arr[i];
                    cnt++;
                    j++;
                }

            }
            // Выводим количество наших простых чисел
            Console.WriteLine(cnt);
            // И выводим наши простые числа через пробел
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(pr[i] + " ");
            }
            // Пишем для того чтобы консольные окно останавливалось
            Console.ReadLine();
        }
    }
}