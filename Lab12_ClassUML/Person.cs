using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public void ToString(string name, string address)
        {
            Console.WriteLine($"{name}, {address}");
        }
    }
}
