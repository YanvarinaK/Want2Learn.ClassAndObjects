using System.Collections.Generic;
using Want2Learn.ClassAndObjects.Enums;

namespace Want2Learn.ClassAndObjects
{
    public interface IPersonService
    {
        Person FirstHighest(List<Person> list);
        Person FirstHighest(Person[] array);
        double GetAverageAge(List<Person> list);
        double GetAverageHeight(List<Person> list);
        double GetAverageWeight(List<Person> list);
        List<Person> GetFemaleList(List<Person> list);
        List<Person> GetList(List<Person> list, Gender gender);
        List<Person> GetMaleList(List<Person> list);
        void Print(List<Person> list);
        void Print(Person person);
        void Print(Person[] array);
        Person ReadFromJson(string fileName);
        List<Person> ReadFromJsonCollection(string fileName);
        List<Person> SortByFullname(List<Person> persons, SortDirection type);
        List<Person> SortByGender(List<Person> persons, SortDirection type);
        List<Person> SortByHeight(List<Person> persons, SortDirection type);
        List<Person> SortByWeight(List<Person> persons, SortDirection type);
        void WriteToJson(List<Person> persons, string fileName);
        void WriteToJson(Person person, string fileName);
        void WriteToTxt(List<Person> persons, string path);
        void WriteToTxt(Person person, string path);
    }
}