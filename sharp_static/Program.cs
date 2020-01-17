using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_static
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 3;
            arr[1] = 5;
            arr[2] = 1;
            arr[3] = 5;
            arr[4] = 3;
            arr[5] = 8;
            arr[6] = 9;
            arr[7] = 34;
            arr[8] = 43;
            arr[9] = 33;

            Console.Write(string.Format("{0, 25}", "Original array: "));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.MySort();

            Console.Write(string.Format("{0, 25}", "Sorted array to upper: "));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.MySort(false);

            Console.Write(string.Format("{0, 25}", "Sorted array to lower: "));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=============================================================================");

            string str1 = "Hello! My name is Andrew!";
            string str2 = "Hello";
            string str3 = "ew!";
            string str4 = null;
            string str5 = "hhh";
            string str6 = "";
            string str7 = "dddddwdadawdawdadawdawdawdwdawdawdawdw";

            Console.WriteLine("MySubstring: ");
            Console.WriteLine(str1.MySubstring(5));
            Console.WriteLine(str1.MySubstring(2, 7));
            Console.WriteLine("Substring: ");
            Console.WriteLine(str1.Substring(5));
            Console.WriteLine(str1.Substring(2,7));
            //Console.WriteLine(str4.Substring(3));

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("IndexOf: ");
            Console.WriteLine(str1.IndexOf(str2));
            Console.WriteLine(str1.IndexOf(str3));
            //Console.WriteLine(str1.IndexOf(str4));
            Console.WriteLine(str1.IndexOf(str5));
            Console.WriteLine(str1.IndexOf(str6));
            Console.WriteLine(str1.IndexOf(str7));
            Console.WriteLine(str6.IndexOf(str2));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("MyIndexOf: ");
            Console.WriteLine(str1.MyIndexOf(str2));
            Console.WriteLine(str1.MyIndexOf(str3));
            //Console.WriteLine(str1.MyIndexOf(str4));
            Console.WriteLine(str1.MyIndexOf(str5));
            Console.WriteLine(str1.MyIndexOf(str6));
            Console.WriteLine(str1.MyIndexOf(str7));
            Console.WriteLine(str6.MyIndexOf(str2));



            Console.ReadKey();
        }
    }
}
