using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_cc_eFRAIM
{
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }

        public Student(int grade, string name)
        {
            Grade = grade;
            Name = name;
        }
    }
}
