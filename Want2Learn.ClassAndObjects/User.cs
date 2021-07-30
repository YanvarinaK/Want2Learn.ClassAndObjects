using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public class User
    {
        private string login;
        private string email;
        private string password;
        private string fullName;
        private bool isDeleted;

        public void SetLogin(string value)
        {
            login = value;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetFullName(string value)
        {
            fullName = value;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetIsDeleted(bool value)
        {
            isDeleted = value;
        }

        public bool GetIsDeleted()
        {
            return isDeleted;
        }

    }
}
