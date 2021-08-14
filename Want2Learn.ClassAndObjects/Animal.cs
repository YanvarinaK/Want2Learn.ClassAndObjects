using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Want2Learn.ClassAndObjects.Enums;

namespace Want2Learn.ClassAndObjects
{
    public class Animal
    {
        public string Name { get; set; }
        public Color AnimalColor { get; set; }

        public virtual string GetInfo()
        {
            string info = String.Format("Name: {0}, Color: {1}", Name, AnimalColor);
            return info;
        }
    }

}
