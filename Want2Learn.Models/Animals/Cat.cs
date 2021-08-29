using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Models.Animals
{
    public class Cat : Animal
    {
        public bool HasAggs { get; set; }

        public override string GetInfo()
        {
            string info = String.Format("Name: {0}, Color: {1}, HasAggs: {2}", Name, AnimalColor, HasAggs);
            return info;
        }
    }
}
