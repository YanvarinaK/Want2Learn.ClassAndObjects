using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.Models.Persons
{
   public class Person
    {
        private Guid id;
        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("ValidationException");
                }
                firstName = value;
            }
        }

        private string middleName;
        public string MiddleName
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("ValidationException");
                }
                else
                {
                    middleName = value;
                }
            }
            get
            {
                return middleName;
            }
        }

        private string lastName;
        public string LastName
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("ValidationException");
                }
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = String.Format("{0} {1} {2}", LastName, FirstName, MiddleName);
                return fullName;
            }
        }

        private Gender gender;
        public Gender Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }

        private double height;
        public double Height
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ValidationException");
                }
                else
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }

        private double weight;
        public double Weight
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ValidationException");
                }
                else
                {
                    weight = value;
                }
            }
            get
            {
                return weight;
            }
        }

        private int age; 
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ValidationException");
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }

        public Person()
        {
        
        }

        public Person(string firstName, string middleName, string lastName, Gender gender, double height, double weight, int age)
        {
            id = Guid.NewGuid();
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }

        public string GetInfo()
        {
            string Info = String.Format("ФИО: {0} {1} {2}, пол: {3}, рост: {4} см, вес: {5} кг, возраст: {6}", lastName, firstName, middleName, gender, height, weight, age);
            return Info;
        }

     
    }
}
