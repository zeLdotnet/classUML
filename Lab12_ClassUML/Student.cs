using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Student:Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        

        public Student(string program, int year, double fee, string name, string address)
            : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public void ToString(string name, string address, string program, int year, double fee)
        {
            Console.WriteLine($"{name}, {address}, {program}, {year}, {fee}");
        }
    }
}
