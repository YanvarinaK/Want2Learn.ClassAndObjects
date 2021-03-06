using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Models.Persons
{
    public class Employee
    {
        public Guid Id { get; set; }

        public DateTime EmployementDate { get; set; }

        public string Position { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - DateOfBirth.Year;
                DateTime birthInThisYear = new DateTime(DateTime.Today.Year, DateOfBirth.Month, DateOfBirth.Day);
                if (DateTime.Today < birthInThisYear)
                {
                    age--;
                }
                return age;
            }
        }

        public int Experience
        {
            get
            {
                int experience = (DateTime.Today.Year - EmployementDate.Year) * 12 + (DateTime.Today.Month - EmployementDate.Month);
                DateTime anniversary = new DateTime(DateTime.Today.Year, DateTime.Today.Month, EmployementDate.Day);
                if (DateTime.Today < anniversary)
                {
                    experience--;
                }
                if (experience < 0)
                {
                    return 0;
                }
                return experience;
            }
        }

        public Employee(Guid id, DateTime employementDate, string position, string fullName, decimal salary, DateTime dateOfBirth)
        {
            Id = id;
            EmployementDate = employementDate;
            Position = position;
            FullName = fullName;
            Salary = salary;
            DateOfBirth = dateOfBirth;
        }

        public Employee()
        {
        
        }

        public string GetInfo()
        {
            string info = String.Format("ФИО: {0}, Возраст: {1}, Опыт работы: {2}, Должность: {3}, ЗП: {4} ", FullName, Age, Experience, Position, Salary);
            return info;
        }

    }
}
