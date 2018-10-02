using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");


            Console.ReadKey();
        }

        public static void PrintPerson(Student student) {
            Console.WriteLine(student.FormatIdAndName("Daniel Ubilla", 1));
        }

        public static void PrintPerson(StudentC studentC) {
            Console.WriteLine(studentC.FormatIdAndName("Daniel Ubilla", 1));
        } 
    }
}
