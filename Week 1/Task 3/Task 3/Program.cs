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
            string s = Console.ReadLine();
            string[] b = s.Split();
            for(int i = 0; i < b.Length; i++)
            {
                arr[i] = int.Parse(b[i]);
            }
            int[] q = new int[2 * arr.Length];
            for(int i = 0; i < q.Length; i++)
            {
                q[i] = arr[i / 2];
            }
            for(int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
