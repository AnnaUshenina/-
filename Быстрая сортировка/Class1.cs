using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Быстрая_сортировка
{
    public class Sort
    {
        
        public static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var p = Partition(array, start, end);
                QuickSort(array, start, p - 1);
                QuickSort(array, p, end);
            }
        }

        private static int Partition(int[] array, int start, int end)
        {
            var pivot = array[start];
            var left = start;
            var right = end;
            var lenght = array.Length;
            while (left <= right)
            {
                while (array[left] < pivot && left < lenght - 1)
                    left++;
                while (array[right] > pivot && right > 0)
                    right--;
                if (left <= right)
                {
                    var container = array[left];
                    array[left] = array[right];
                    array[right] = container;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
