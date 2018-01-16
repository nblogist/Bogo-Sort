using System;
using System.Collections.Generic;
using System.IO;

namespace BOGO_Sort
{
    class Program
    {
        public static void BogoSort(ref int[] a)
        {
            while (!Sorted(a))
            {
                Shuffle(ref a);
            }
            Console.WriteLine("Printing Array");
            foreach (var VARIABLE in a)
            {
                Console.Write(VARIABLE+", ");
            }
        }

        public static void Shuffle(ref int[] a)
        {
            var ran= new Random();
            for (int i =0; i < a.Length; i++)
            {
                Swap(ref a[i], ref a[ran.Next(a.Length)]);
            }
        }

        public static bool Sorted(int[] a)
        {
            for (int i = a.Length-1; i > 0 ; i--)
            {
                if (a[i]<a[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            var a=new List<int>();
            using (var file=new StreamReader(@"C:\Users\FURQAN\Desktop\Read.txt"))
            {
                while (true)
                {
                    a.Add(Convert.ToInt32(file.ReadLine()));
                    if (file.EndOfStream)
                    {
                       break;
                    }
                }
            }
            var aa = a.ToArray();
            BogoSort(ref aa);
        }
    }
}
