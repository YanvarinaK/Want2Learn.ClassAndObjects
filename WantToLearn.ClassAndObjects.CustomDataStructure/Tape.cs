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
        private TapeItem<T> LastItem
        {
            get
            {
                TapeItem<T> lastItem = FirstItem;
                while (lastItem.NextItem != null)
                {
                    lastItem = lastItem.NextItem;
                }
                return lastItem;
            }
        }
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
                Count++;
                return;
            }
            LastItem.NextItem = newItem;
            newItem.PrevItem = LastItem;
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
                Count++;
                return;
            }
            newItem.NextItem = FirstItem;
            FirstItem = newItem;
            Count++;
        }

        private TapeItem<T> GetByIndex(int index)
        {
            if (FirstItem == null)
            {
                return null;
            }
            int counter = 0;
            TapeItem<T> currentItem = FirstItem;
            while (counter != index)
            {
                if (currentItem.NextItem == null)
                {
                    return null;
                }
                currentItem = currentItem.NextItem;
                counter++;
            }

            return currentItem;
        }

        public T GetValueByIndex(int index)
        {
            if (FirstItem == null)
            {
                return default(T);
            }
            int counter = 0;
            TapeItem<T> currentItem = FirstItem;
            while (counter != index)
            {
                if (currentItem.NextItem == null)
                {
                    return default(T);
                }
                currentItem = currentItem.NextItem;
                counter++;
            }

            return currentItem.Value;
        }

        public void RemoveFromStart()
        {
            FirstItem = FirstItem.NextItem;
            Count--;
        }

        public void RemoveFromEnd()
        {
            TapeItem<T> itemBeforeLast = GetByIndex(Count - 2);
            itemBeforeLast.NextItem = null;
            Count--;
        }
    }
}

