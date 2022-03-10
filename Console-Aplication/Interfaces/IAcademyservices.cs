using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Aplication.Interfaces
{
    interface Iacademyservices
    {
        public List<Group> Groups { get; }
        public string CreatGroup(Categories category);
        public void EditGroup(string No, string newNo);
        public void GetAllGroup();
        public void GetAllStudents();
        public void CreatStudents(string No, string fullname);
        public void StudentGroupListShow(string No);

    }
}
