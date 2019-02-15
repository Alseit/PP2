using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем DirectoryInfo dir и открываем к ней доступ через ссылку
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\АПИТУ\Desktop\PP2\Week 2");
            // Вызываем функцию
            PrintInfo(dir, 0);
            Console.ReadKey();
        }
        // Через этот метод пишем названия папок и файлов, и то что внутри папок пишем через 5 пробелов на следующей строке и тд
        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);

            if(fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for(int i = 0; i < arr.Length; i++)
                {
                    PrintInfo(arr[i], k + 5);
                }
            }
        }
    }
}
