using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Want2Learn.ClassAndObjects.Enums;

namespace Want2Learn.ClassAndObjects
{
    public class PersonService : IPersonService
    {
        public Person FirstHighest(Person[] array)
        {
            if ((array == null) || (array.Length == 0))
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
            if ((list == null) || (list.Count == 0))
            {
                return null;
            }
            Person highest = list[0];
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
            if (array == null)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Print(array[i]);
            }
            Console.WriteLine();
        }

        public void Print(List<Person> list)
        {
            if (list == null)
            {
                return;
            }
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

        public double GetAverageAge(List<Person> list)
        {
            if ((list == null) || (list.Count == 0))
            {
                return 0;
            }
            double sumOfAges = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfAges = sumOfAges + list[i].Age;
            }
            double AverAge = sumOfAges / list.Count;
            return AverAge;
        }

        public double GetAverageHeight(List<Person> list)
        {
            if ((list == null) || (list.Count == 0))
            {
                return 0;
            }
            double sumOfHeights = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfHeights = sumOfHeights + list[i].Height;
            }
            double AverHeight = sumOfHeights / list.Count;
            return AverHeight;
        }

        public double GetAverageWeight(List<Person> list)
        {
            if ((list == null) || (list.Count == 0))
            {
                return 0;
            }
            double sumOfWeights = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfWeights = sumOfWeights + list[i].Weight;
            }
            double AverWeight = sumOfWeights / list.Count;
            return AverWeight;
        }

        public List<Person> GetMaleList(List<Person> list)
        {
            List<Person> maleList = new List<Person>();
            if (list == null)
            {
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Gender == Gender.Man)
                {
                    maleList.Add(list[i]);
                }
            }
            return maleList;
        }

        public List<Person> GetFemaleList(List<Person> list)
        {
            List<Person> feMaleList = new List<Person>();
            if (list == null)
            {
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Gender == Gender.Woman)
                {
                    feMaleList.Add(list[i]);
                }
            }
            return feMaleList;
        }

        public List<Person> GetList(List<Person> list, Gender gender)
        {
            switch (gender)
            {
                case Gender.Man:
                    return GetMaleList(list);
                case Gender.Woman:
                    return GetFemaleList(list);
                default:
                    return null;
            }
        }

        public List<Person> SortByHeight(List<Person> persons, SortDirection type)
        {
            if (persons == null)
            {
                return null;
            }

            switch (type)
            {
                case SortDirection.Asc:
                    return persons.OrderBy(u => u.Height).ToList();
                case SortDirection.Desc:
                    return persons.OrderByDescending(u => u.Height).ToList();
                default:
                    return null;
            }
        }

        public List<Person> SortByWeight(List<Person> persons, SortDirection type)
        {
            if (persons == null)
            {
                return null;
            }

            switch (type)
            {
                case SortDirection.Asc:
                    return persons.OrderBy(u => u.Weight).ToList();

                case SortDirection.Desc:
                    return persons.OrderByDescending(u => u.Weight).ToList();
                default:
                    return null;
            }
        }

        public List<Person> SortByFullname(List<Person> persons, SortDirection type)
        {
            if (persons == null)
            {
                return null;
            }

            switch (type)
            {
                case SortDirection.Asc:
                    List<Person> AscSort = persons.OrderBy(u => u.FullName).ToList();
                    return AscSort;
                case SortDirection.Desc:
                    List<Person> DescSort = persons.OrderByDescending(u => u.FullName).ToList();
                    return DescSort;
                default:
                    return null;
            }
        }

        public List<Person> SortByGender(List<Person> persons, SortDirection type)
        {
            if (persons == null)
            {
                return null;
            }

            switch (type)
            {
                case SortDirection.Asc:
                    return persons.OrderBy(u => u.Gender).ToList();
                case SortDirection.Desc:
                    return persons.OrderByDescending(u => u.Gender).ToList();
                default:
                    return null;
            }
        }

        public void WriteToTxt(Person person, string path)
        {
            if ((person == null) || (path == null))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(person.GetInfo());
            }
        }

        public void WriteToTxt(List<Person> persons, string path)
        {
            if ((persons == null) || (path == null))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < persons.Count; i++)
                {
                    sw.WriteLine(persons[i].GetInfo());

                }
            }
        }

        public void WriteToJson(Person person, string fileName)
        {
            if ((person == null) || (fileName == null))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));
            }
        }

        public void WriteToJson(List<Person> persons, string fileName)
        {
            if ((persons == null) || (fileName == null))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(JsonConvert.SerializeObject(persons, Formatting.Indented));
            }
        }

        public Person ReadFromJson(string fileName)
        {
            if (fileName == null)
            {
                return null;
            }
            Person somePerson = new Person();
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                somePerson = JsonConvert.DeserializeObject<Person>(streamReader.ReadToEnd());
            }
            return somePerson;
        }

        public List<Person> ReadFromJsonCollection(string fileName)
        {
            if (fileName == null)
            {
                return null;
            }
            List<Person> persons = new List<Person>();
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                persons = JsonConvert.DeserializeObject<List<Person>>(streamReader.ReadToEnd());
            }
            return persons;
        }
    }
}
