using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    class Address
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

        private string city;
        public string City
        {
            set
            {
                if (value == null)
                {
                    city = String.Empty;
                }
                else
                {
                    city = value;
                }
            }
            get
            {
                return city;
            }
        }

        private string street;
        public string Street
        {
            set
            {
                if (value == null)
                {
                    street = String.Empty;
                }
                else
                {
                    street = value;
                }
            }
            get
            {
                return street;
            }
        }

        private int houseNumber;
        public int HouseNumber
        {
            set
            {
                if (value < 0)
                {
                    houseNumber = 0;
                }
                else
                {
                    houseNumber = value;
                }
            }
            get
            {
                return houseNumber;
            }
        }

        private int apartment;
        public int Apartment
        {
            set
            {
                if (value < 0)
                {
                    apartment = 0;
                }
                else
                {
                    apartment = value;
                }
            }
            get
            {
                return apartment;
            }
        }

        public Address()
        {
        
        }

        public Address(string city, string street, int houseNumber, int apartment)
        {
            id = Guid.NewGuid();
            this.city = city;
            this.street = street;
            this.houseNumber = houseNumber;
            this.apartment = apartment;

        }

        public string GetInfo()
        {
            string FullAddress = String.Format("г. {0}, ул. {1}, д. {2}, кв. {3}.", city, street, houseNumber, apartment);
            return FullAddress;
        }
    }
}
