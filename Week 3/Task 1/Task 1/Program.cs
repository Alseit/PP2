using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        class FarManager
        {
            public int cursor;
            public string path;
            public int sz;
            public FileSystemInfo currentfs = null;
            public DirectoryInfo dir = null;
            public FarManager()
            {
                cursor = 0;
            }
            public FarManager(string path)
            {
                this.path = path;
                cursor = 0;
                dir = new DirectoryInfo(path);
                sz = dir.GetFileSystemInfos().Length;// Размер папки(количество папок + файлов в нем)
            }
            public void Color(FileSystemInfo f, int index)
            {
                if (cursor == index)// Выделить папку или файл, который показывает курсор
                {
                    currentfs = f;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;// Если это папка то мы окрашиваем в зеленый
                }
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;// В противном случае в желтый
            }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                dir = new DirectoryInfo(path);
                int ind = 1;
                FileSystemInfo[] fs = dir.GetFileSystemInfos();// Мы доабляем в массив все filesystemonfos(папки и файлы) из данной папки
                for (int i = 0; i < fs.Length; i++)
                {
                    Color(fs[i], i);// Мы пытаемся раскрасить каждый элемент массива
                    Console.WriteLine(ind + "." + " " + fs[i]);
                    ind++;
                }
            }
            public void Up()// Функция чтобы идти вверх по списку
            {
                cursor--;
                if (cursor < 0)// Когда мы хотим пойти выше первого элемента, он должен перейти к последнему элементу
                {
                    cursor = sz - 1;
                }
            }
            public void Down()// Когда мы хотим перейти под последний элемент, он должен перейти к первому
            {
                cursor++;
                if (cursor == sz)
                {
                    cursor = 0;
                }
            }
            public void Start()
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                while (keyinfo.Key != ConsoleKey.Escape)// При нажатий "Escape" программа перестает работать
                {
                    Show();
                    keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.UpArrow)
                    {
                        Up();
                    }
                    else if (keyinfo.Key == ConsoleKey.DownArrow)
                    {
                        Down();
                    }
                    if (keyinfo.Key == ConsoleKey.Enter)// Я выбираю элемент массива, затем нажимаю "Enter"
                    {
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {// Если это папка он вернет проход, который включает этот каталог
                         // Это означает, что мы идем в папку
                            cursor = 0;
                            path = currentfs.FullName;
                        }
                        if (currentfs.GetType() == typeof(FileInfo))// Если это файл, то мы открываем его в console(textfiles)
                        {
                            cursor = 0;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            using (StreamReader sr = new StreamReader(currentfs.FullName))// Мы читаем контекст файла
                            {
                                Console.WriteLine(sr.ReadToEnd());// Мы печатаем с функцией ReadtoEnd
                            }
                            Console.ReadKey();
                        }
                    }
                    if (keyinfo.Key == ConsoleKey.Delete)// Здесь мы пытаемся удалть элементы массива с помощью кнопки "delete"
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {

                            if (new DirectoryInfo(currentfs.FullName).GetFileSystemInfos().Length == 0)// Если это папка, которая пуста, то нет проблем, он будет удален
                            {
                                Directory.Delete(currentfs.FullName);
                            }
                            else// Но если в этой папке есть файлы или подпапки, мы должны спросить, уверены ли они
                            {
                                Console.Clear();
                                Console.WriteLine("Are you sure?");
                                if (Console.ReadKey().Key == ConsoleKey.Y)// Если да, то удалить
                                {
                                    Directory.Delete(currentfs.FullName, true);
                                }



                            }
                        }

                        else if (currentfs.GetType() == typeof(FileInfo))// Удаление файлов
                        {
                            File.Delete(currentfs.FullName);
                        }
                    }

                    if (keyinfo.Key == ConsoleKey.I)// Нажимая "I", мы пытаемся переименовать данный файл или папку
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            Console.Clear();
                            string s = Console.ReadLine();// Мы пишем имя которое хотим поменять
                            string Name = currentfs.Name;// Просто простое имя папки
                            string fName = currentfs.FullName;// Расположение папки
                            string newpath = "";
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                newpath += fName[i];// Путь, по которому хранится папка
                            }
                            newpath = newpath + s;
                            Directory.Move(fName, newpath);// Меняет имя
                        }
                        else
                        {
                            Console.Clear();
                            string s = Console.ReadLine();
                            string Name = currentfs.Name;
                            string fName = currentfs.FullName;
                            string newpath = "";
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                newpath += fName[i];
                            }
                            newpath = newpath + s;
                            File.Move(fName, newpath);
                        }

                    }
                    if (keyinfo.Key == ConsoleKey.Backspace)// Нажав "Backspace", я возврощаюсь в последнюю папку
                    {
                        cursor = 0;
                        path = dir.Parent.FullName;
                    }

                }
            }

            static void Main(string[] args)
            {
                string path = @"C:\Users\АПИТУ\Desktop\PP2";
                FarManager fr = new FarManager(path);
                fr.Start();
            }
        }
    }
}
