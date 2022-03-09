using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp32.Enum;

namespace ConsoleApp32.Student
{
    internal class Student
    {
        public string Fullname { get; set; }

        public int GroupNo { get; set; }
        
        public StudentType StudentType { get; set; }
        public bool IsOnline { get; private set; }

        public Student(string fullname , int groupNo , StudentType studentType)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            StudentType = studentType;
        }

        public override string ToString()
        {
            string isWaranty = (int)StudentType == 1 ? "zenametli" : "zemanetsiz";
            string isOnline = IsOnline ? "Online" : "Ofline";

            return $"Ad Soyad: {Fullname}\nQroup nomresi: {GroupNo}\nZemanet Novu: {isWaranty}";
        }

    }

}
