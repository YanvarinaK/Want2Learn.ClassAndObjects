using System;

namespace Want2Learn.Models.Animals
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
