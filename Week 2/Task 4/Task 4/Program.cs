using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Если такой файл не существует то создаем этот файл и открываем к нему доступ и пишем в него "Hello Apitu!"
            if (!File.Exists(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Apitu.txt"))
            {
                using (FileStream fs = new FileStream(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Apitu.txt", FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("Hello Apitu!");
                    }
                }
            }
            //Если такая папка не  существует то создаeм эту папку
            if (!Directory.Exists(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Utipa"))
            {
                Directory.CreateDirectory(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Utipa");
            }
            //В начале пишем начальную папку и файл, потом пишем вторую папку и файл куда мы отправим начльный файл
            string TheFirstFile = Path.Combine(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4", "Apitu.txt");
            string TheSecondFile = Path.Combine(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Utipa", "Apitu.txt");
            //Если такой файл существует в начальней папке и не существует во второй папке то копию этого файла отправляем в другую папку
            if (!File.Exists(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Utipa\Apitu.txt"))
            {
                File.Copy(TheFirstFile, TheSecondFile, true);
            }
            //Если файл существует в начальной папке то удаляем его
            if (File.Exists(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Apitu.txt"))
            {
                File.Delete(@"C:\Users\АПИТУ\Desktop\PP2\Week 2\Task 4\Apitu.txt");
            }
        }
    }
}