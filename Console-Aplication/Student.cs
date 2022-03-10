using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication
{
    internal class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;
        public Student(string fullname, string groupNo)
        {

            Fullname = fullname;
            GroupNo = groupNo;
        }
        public override string ToString()
        {
            return $"Fullname:{Fullname} GroupNo:{GroupNo}";
        }
    }
}
