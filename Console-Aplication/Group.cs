using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication
{
    class Group
    {
        public static int count = 1;
        public string No;
        public bool IsOnline;
        public int Limit;
        public List<Student> Students = new List<Student>();
        public Categories Category;
        public Group(Categories category)
        {
            switch (Category)
            {
                case Categories.Programing:
                    No = $"P{count}";
                    break;
                case Categories.System_Adminstration:
                    No = $"S{count}";
                    break;
                case Categories.Design:
                    No = $"D{count}";
                    break;
                default:
                    break;
            }

            Category = category;
            count++;
        }
        

    }
}
