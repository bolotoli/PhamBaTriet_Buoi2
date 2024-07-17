using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    class Program
    {
        
        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            
            int[] L = new int[n1];
            int[] R = new int[n2];

      
            for (int i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[middle + 1 + j];

          
            int k = left;
            int p = 0, q = 0;
            while (p < n1 && q < n2)
            {
                if (L[p] <= R[q])
                {
                    arr[k] = L[p];
                    p++;
                }
                else
                {
                    arr[k] = R[q];
                    q++;
                }
                k++;
            }

          
            while (p < n1)
            {
                arr[k] = L[p];
                p++;
                k++;
            }

            
            while (q < n2)
            {
                arr[k] = R[q];
                q++;
                k++;
            }
        }

        
        static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                
                Merge(arr, left, middle, right);
            }
        }

        
        static void InMang(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        
        public static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Mang ban dau:");
            InMang(arr);

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nMang da sap xep:");
            InMang(arr);
        }
    }
}