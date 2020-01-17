using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_static
{
    static class Calculator
    {
        // я не стал заморачиватся с алгоритмами сортировки так как я так понял что задача не в этом
        // но если все-таки нужно было, то могу реализовать что-нибудь интереснее
        public static void MySort(this int[] arr, bool toBigger = true)
        {
            if (arr == null)
            {
                return;
            }

            if (arr.Length < 2)
            {
                return;
            }

            if (toBigger)
            {
                SortToBigger(arr);
            }
            else
            {
                SortToLower(arr);
            }
           
        }

        private static void SortToBigger(int[] arr)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1 - y; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }

        private static void SortToLower(int[] arr)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1 - y; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }

    }
}
