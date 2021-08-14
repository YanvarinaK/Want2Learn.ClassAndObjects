using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public class EmployeeService : IEmployeeService
    {
        public void Print(Employee employee)
        {
            if (employee == null)
            {
                return;
            }
            string output = employee.GetInfo();
            Console.WriteLine(output);
            Console.WriteLine();
        }

        public void Print(List<Employee> employees)
        {
            if (employees == null)
            {
                return;
            }
            foreach (var item in employees)
            {
                Print(item);
            }
            Console.WriteLine();
        }

        public void Swap(List<Employee> employees, int i, int j)
        {
            Employee Temp = employees[i];
            employees[i] = employees[j];
            employees[j] = Temp;
        }

        public void SortBySalary(List<Employee> employees)
        {
            if (employees == null)
            {
                return;
            }
            QSort(employees, 0, employees.Count - 1);
        }


        private void QSort(List<Employee> employees, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            var pivotIndex = Sorting(employees, left, right);
            QSort(employees, left, pivotIndex - 1);
            QSort(employees, pivotIndex + 1, right);

        }

        private int Sorting(List<Employee> employees, int left, int right)
        {
            var pivot = left;
            for (int i = left; i < right; i++)
            {
                if (employees[i].Salary < employees[right].Salary)
                {

                    Swap(employees, i, pivot);
                    pivot++;
                }
            }

            Swap(employees, pivot, right);
            return pivot;
        }

        public void SortByAge(List<Employee> employees)
        {
            if (employees == null)
            {
                return;
            }
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Age > employees[j].Age)
                    {
                        Swap(employees, i, j);
                    }
                }
            }
        }

        public void SortByExperience(List<Employee> employees)
        {
            if (employees == null)
            {
                return;
            }
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Experience > employees[j].Experience)
                    {
                        Swap(employees, i, j);
                    }
                }
            }
        }

        public List<Employee> GetByPosition(List<Employee> employees, string position)
        {
            if (employees == null)
            {
                return null;
            }
            List<Employee> newList = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Position.ToLower() == position.ToLower())
                {
                    newList.Add(employees[i]);
                }
            }
            return newList;
        }

        public List<Employee> GetByAge(List<Employee> employees, int age)
        {
            if (employees == null)
            {
                return null;
            }
            List<Employee> newList = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Age == age)
                {
                    newList.Add(employees[i]);
                }
            }
            return newList;
        }

        public List<Employee> GetByExperience(List<Employee> employees, int experience)
        {
            if (employees == null)
            {
                return null;
            }
            List<Employee> newList = new List<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Experience == experience)
                {
                    newList.Add(employees[i]);
                }
            }
            return newList;
        }


    }
}
