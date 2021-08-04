﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
   public class PersonService
    {
        public Person FirstHighest(Person[] array)
        {
            if (array == null)
            {
                return null;
            }
            Person highest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Height > highest.Height)
                {
                    highest = array[i];
                }
            }
            return highest;
        }

        public Person FirstHighest(List<Person> list)
        {
            if (list == null)
            {
                return null;
            }
            Person highest = new Person();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Height > highest.Height)
                {
                    highest = list[i];
                }
            }
            return highest;
        }

        public void Print(Person[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Print(array[i]);
            }
            Console.WriteLine();
        }

        public void Print(List<Person> list)
        {
            foreach (var item in list)
            {
                Print(item);
            }
            Console.WriteLine();
        }

        public void Print(Person person)
        {
            if (person == null)
            {
                return;
            }
            string output = person.GetInfo();
            Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}
