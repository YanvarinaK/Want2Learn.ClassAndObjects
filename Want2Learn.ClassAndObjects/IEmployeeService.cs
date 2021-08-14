using System.Collections.Generic;

namespace Want2Learn.ClassAndObjects
{
    public interface IEmployeeService
    {
        List<Employee> GetByAge(List<Employee> employees, int age);
        List<Employee> GetByExperience(List<Employee> employees, int experience);
        List<Employee> GetByPosition(List<Employee> employees, string position);
        void Print(Employee employee);
        void Print(List<Employee> employees);
        void SortByAge(List<Employee> employees);
        void SortByExperience(List<Employee> employees);
        void SortBySalary(List<Employee> employees);
        void Swap(List<Employee> employees, int i, int j);
    }
}