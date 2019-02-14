using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Главная точка входа в проект
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Создаем переменную Pol типа bool
            bool Pol = true;

            // Считываем данные из файла
            using (FileStream fs = new FileStream(@"C: \Users\АПИТУ\Desktop\PP2\Week 2\Task 1\input.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    // Создаем переменную text типа string и сохраняем все элементы файла в texte 
                    // После эту переменную проверяем через типа bool на палиндромность и записываем ответ а переменную типа bool
                    // Если text палиндром то true, а если не палиндром то false 
                    string text = sr.ReadLine();
                    Pol = Polindrome(text);
                    if(Pol == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Проверка на Палиндромность
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool Polindrome(string text) 
        {
            // Создаем цикл чтобы пробежаться по элементам массива типа char
            for(int i = 0; i < (text.Length) / 2; i++)
            {
                // Здесь через условие проверяем 1 элемент массива и последний элемент массива
                // Если они одинаковые то переходим на следующий элемент
                // А если не одинаковые то выводим false и выходим из функции
                if(text[i] != text[text.Length - 1 - i])
                {
                return false;
                }
            }
            return true;
        }
    }
}
