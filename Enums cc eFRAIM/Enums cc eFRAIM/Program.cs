using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_cc_eFRAIM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> SL = new List<Student>();
            Student s1 = new Student(10, "Ron");
            Student s2 = new Student(6, "Efraim");
            Student s3 = new Student(12, "Dor");

            SL.Add(s1);
            SL.Add(s2);
            SL.Add(s3);


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*10);
            }

            foreach (var item in new Sidra10to100())
            {
                Console.WriteLine(item);
            }

            foreach (var item in new SidraPower(3))
            {
                Console.WriteLine(item);
            }

            foreach (Student item in new StudentWhoParcticeAlot(SL))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
