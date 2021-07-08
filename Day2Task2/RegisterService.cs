using Day2Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task2
{
    public class RegisterService
    {
        private Person _person;
        public RegisterService()
        {
            _person = new Person("K.c.");
            Register();
        }

        private void Register()
        {
            Console.WriteLine($"Registering {_person.FullName}");
        }
    }
}
