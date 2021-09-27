using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_cc_eFRAIM
{
    public class SidraPower : IEnumerable<double>
    {
        double Power;

        public SidraPower(double power)
        {
            Power = power;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return Math.Pow(Power,i);
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Sidra10to100 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i  <= 10; i ++)
            {
                yield return i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class StudentWhoParcticeAlot : IEnumerable<Student>
    {
        public List<Student> StudentList;

        public StudentWhoParcticeAlot(List<Student> studentList)
        {
            StudentList = studentList;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (Student item in StudentList)
            {
                if (item.Grade >= 10)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
