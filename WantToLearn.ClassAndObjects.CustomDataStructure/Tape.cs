using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantToLearn.ClassAndObjects.CustomDataStructure
{
    public class Tape<T>
    {
        private TapeItem<T> FirstItem { get; set; }
        private TapeItem<T> LastItem { get; set; }
        public int Count { get; private set; } = 0;


        public void AddToEnd(T value)
        {
            TapeItem<T> newItem = new TapeItem<T>
            {
                Value = value
            };
            if (FirstItem == null)
            {
                FirstItem = newItem;
                LastItem = newItem;
                Count++;
                return;
            }
            LastItem.NextItem = newItem;
            newItem.PrevItem = LastItem;
            LastItem = newItem;
            Count++;
        }

        public void AddToStart(T value)
        {

            TapeItem<T> newItem = new TapeItem<T>
            {
                Value = value
            };
            if (FirstItem == null)
            {
                FirstItem = newItem;
                LastItem = newItem;
                Count++;
                return;
            }
            newItem.NextItem = FirstItem;
            FirstItem.PrevItem = newItem;
            FirstItem = newItem;
            Count++;
        }

        private TapeItem<T> GetByIndex(int index)
        {
            if ((FirstItem == null) || (index >= Count) || (index< 0))
            {
                return null;
            }
            if (index >= Count/2)
            {
                TapeItem<T> currentItem = LastItem;
                int counter = Count - 1;
                while (counter != index)
                {
                    currentItem = currentItem.PrevItem;
                    counter--;
                }
                return currentItem;
            }
            else
            {
                TapeItem<T> currentItem = FirstItem;
                int counter = 0;
                while (counter != index)
                {
                    currentItem = currentItem.NextItem;
                    counter++;
                }
                return currentItem;
            }
            
        }

        public T GetValueByIndex(int index)
        {
            TapeItem<T> needfulItem = GetByIndex(index);
            if (needfulItem == null)
            {
                return default(T);
            }
            return needfulItem.Value;
        }

        public void RemoveFromStart()
        {
            FirstItem = FirstItem.NextItem;
            Count--;
        }

        public void RemoveFromEnd()
        {
            LastItem = LastItem.PrevItem;
            Count--;
        }
    }
}

