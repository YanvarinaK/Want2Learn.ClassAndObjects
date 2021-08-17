using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
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

    }
}
