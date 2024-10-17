using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProjectStudentManagment
{
    internal class Student
    {
        public int RegNumber { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public long PhoneNumber { get; set; }
        public StudentStatus StudentStatus { get; set; }

        public override string ToString()
        {
            return $"{ RegNumber } { Name } { Standard} { PhoneNumber}";
        }
    }
}
