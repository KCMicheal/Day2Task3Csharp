using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var resgisterService = new RegisterService();
            var person = resgisterService.Person;
        }

    }
}
