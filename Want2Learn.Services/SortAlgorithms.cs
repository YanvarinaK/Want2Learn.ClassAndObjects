using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Services
{
    public class SortAlgorithms
    {

        public void Mix(int[] array)
        {
            int[] keys = new int[array.Length];
            Random rnd = new Random();
            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = rnd.Next();
            }
            Array.Sort(keys, array);
        }

        public void Mix(List<int> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int randIndex = rnd.Next(0, list.Count);
                //(list[i], list[randIndex]) = (list[randIndex], list[i]);
                int temp = list[i];
                list[i] = list[randIndex];
                list[randIndex] = temp;
            }
        }

        public void BubbleSort(int[] Array)
        {
            int Temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                    }
                }
            }

        }

        public void QSort(int[] array)
        {
            QSort(array, 0, array.Length - 1);
        }

        public void QSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = Sorting(array, left, right);
            Sorting(array, left, right);
            QSort(array, left, pivot - 1);
            QSort(array, pivot + 1, right);

        }

        public int Sorting(int[] array, int left, int right)
        {
            int marker = left;
            int pivot = right;
            for (int i = left; i < pivot; i++)
            {
                if (array[i] < array[pivot])
                {
                    Swap(ref array[i], ref array[marker]);
                    marker++;
                }
            }
            Swap(ref array[marker], ref array[pivot]);
            return marker;

        }

        public void Swap(ref int first, ref int second)
        {
            int Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
    }
}
