using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
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
                    middleName = String.Empty;
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
                lastName = value;
            }
            get
            {
                return lastName;
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
                    height = 0;
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
                    weight = 0;
                }
                else
                {
                    weight = value;
                }
            }
        }

        private int age; 
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    age = 0;
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
