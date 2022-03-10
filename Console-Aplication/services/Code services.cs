using System;
using System.Collections.Generic;
using System.Text;
using Console_Aplication.Interfaces;

namespace Console_Aplication.services
{
    class Code_services : Iacademyservices
    {
        private List<Group> _groups = new List<Group>();
      


        public List<Group> Groups => _groups;

        public string CreatGroup( Categories category)
        {
            
            Group group = new Group( category);

            _groups.Add(group);
            return group.No;
        }

        public void CreatStudents(string No, string fullname)
        {
            Group group = FindGroup(No);
            Student student = new Student(fullname,group.No);
            group.Students.Add(student);

        }
        public void EditGroup(string No, string newNo)
        {
            Group existedgroup = FindGroup(No);
            if (existedgroup == null)
            {
                Console.WriteLine("Please choose correct Group No");
                return;
            }
            foreach (Group item in _groups)
            {
                if (existedgroup.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                {
                    Console.WriteLine("This group number already exist");
                    return;
                }
            }
            existedgroup.No= newNo;
            

            foreach (Group group1 in _groups)
            {
                if (group1.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                {
                    Console.WriteLine(existedgroup = group1);
                    return;
                }
            }
            existedgroup.No = newNo.ToUpper();
        }

     

        public Group FindGroup(string newNo)
        {
            Group group;
            foreach (Group item in _groups)
            {
                if (item.No.ToLower().Trim() == newNo.ToLower().Trim()) ;
                { group = item;
                    return group;
                }
            }
            return null;
        }

        public void GetAllGroup()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no Group in the Academy");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        internal void EditGroup()
        {
            throw new NotImplementedException();
        }

        internal void CreatStudents()
        {
            throw new NotImplementedException();
        }

        internal void StudentGroupListShow()
        {
            throw new NotImplementedException();
        }

        public void GetAllStudents()
        {
            foreach (var item in _groups)
            {
                foreach (var item1 in item.Students )
                {
                    Console.WriteLine(item1);
                }
            }

        }

        public void StudentGroupListShow(string No)
        {
            Group group = FindGroup(No);
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }

        }
    }
}