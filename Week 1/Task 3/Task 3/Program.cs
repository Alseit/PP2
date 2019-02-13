using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // Создаем стринг чтобы выводить в консоле, после создаем массив стринга и добавляем в него начальный стринг разделенный пробелами
            string s = Console.ReadLine();
            string[] b = s.Split();
            // Создаем цикл чтобы добавить в массив чисел все числа которые мы вводили в виде стринга в интовом виде
            for(int i = 0; i < b.Length; i++)
            {
                arr[i] = int.Parse(b[i]);
            }
            // Создаем новый массив с удвоенным размером чтобы поместить туда начальный массив с повторение. И через цикл вводим в массив q первый массив с повтором
            int[] q = new int[2 * arr.Length];
            for(int i = 0; i < q.Length; i++)
            {
                q[i] = arr[i / 2];
            }
            // Выводим на консоль массив q
            for(int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
