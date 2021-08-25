using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string ggg = "";
            StringAlgorithms service = new StringAlgorithms();
            var result = service.IsValidEmail("art--em@mail.ru");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
