using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task1
{
    public class Person
    {
        public string Complexion;
        public string EyeColor;
        public int Height;
        public string FullName;

        public Person(string fullName, string complexion, string eye, int height)
        {
            FullName = fullName;
            Complexion = complexion;
            EyeColor = eye;
            Height = height;
        }

        public void Walk()
        {
            Console.WriteLine("walking...");
        }

        public void Talk()
        {
            Console.WriteLine("Talking...");
        }
        public void Eat()
        {

        }
    }
}
