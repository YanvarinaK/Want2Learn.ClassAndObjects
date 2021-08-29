using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Services
{
    public class FindAlgorithms
    {
        public int BinarySearch(int[] array, int value)
        {
            if (array == null)
            {
                return -1;
            }

            int result = Search(array, value, 0, array.Length - 1);
            return result;
        }
        public int Search(int[] array, int value, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int pivot = left + (right - left) / 2;
            if (array[pivot] == value)
            {
                return pivot;
            }
            else
            {
                
                if (array[pivot] > value)
                {
                    return Search(array, value, left, pivot - 1);
                }
                else
                {
                    return Search(array, value, pivot + 1, right);
                }
            }
        }
    }
}

