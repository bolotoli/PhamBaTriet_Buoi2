using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Binary_search
    {
       
        public static int BinarySearchIterative(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

               
                if (array[mid] == key)
                    return mid;

              
                if (array[mid] > key)
                    right = mid - 1;
                else 
                    left = mid + 1;
            }

           
            return -1;
        }

        
        public static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 10, 40 };
            int key = 10;

            int result = BinarySearchIterative(array, key);

            if (result != -1)
                Console.WriteLine("Phan tu duoc tim thay tai vi tri: " + result);
            else
                Console.WriteLine("Phan tu khong co trong mang");

            
            Console.ReadLine();
        }
    }
}
