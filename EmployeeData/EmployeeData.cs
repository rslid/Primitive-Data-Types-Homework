using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = "Pesho";
            string lastName = "Petrov";
            byte age = 33;
            char gender = 'm';
            ulong personalID = 8306112507;
            int uniqueNumber = 27560000;

            Console.WriteLine("The name of employee is {0} {1}, he is {2} old, gender {3} with Personal ID number {4}. His Unique employee number is {5}", name, lastName, age, gender, personalID, uniqueNumber);

        }
    }
}
