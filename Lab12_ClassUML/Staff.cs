using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Staff:Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string school, double pay, string name, string address)
            :base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }

        public void ToString(string name, string address, string school, double pay)
        {
            Console.WriteLine($"{name}, {address}, {school}, {pay}");
        }
    }
}
