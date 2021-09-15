using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantToLearn.ClassAndObjects.CustomDataStructure
{
    public class TapeItem<T>
    {
        public T Value { get; set; }
        public TapeItem<T> NextItem { get; set; }
        public TapeItem<T> PrevItem { get; set; }
    }
}
