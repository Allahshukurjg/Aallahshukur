using System;
using Console_Aplication.services;
using Mono.Cecil.Cil;

namespace Console_Aplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Code_services code = new Code_services();
            Console.WriteLine("Academy Application\n");
            int selection;
            do
            {
                Console.WriteLine("1.Qrup yarat");
                Console.WriteLine("2.Qrup düzelt");
                Console.WriteLine("3.Bütün qrupu elde edin");
                Console.WriteLine("4.Butun telebeler");
                Console.WriteLine("5.Telebe yarat");
                Console.WriteLine("6.StudentGroupListShow");
                Console.WriteLine("0.Exit");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);  

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Choose Category:");
                            Console.WriteLine("1.Programming" +
                                "2.System Administration" +
                                "3.Design");

                            string str = Console.ReadLine();
                            Categories categories = Categories.Programing;
                            if (str=="1")
                            {
                                categories = Categories.Programing;
                            }
                            else if (str == "2")
                            {
                                categories = Categories.System_Adminstration;
                            }
                            else if (str=="3")
                            {
                                categories = Categories.Design;
                            }
                            code.CreatGroup(categories);
                            break;
                        case 2:
                            Console.WriteLine("Please enter group no");
                            Console.WriteLine("Please enter new group no");
                            code.EditGroup();
                            break;
                        case 3:code.GetAllGroup();
                            break;
                        case 4:code.GetAllStudents();
                            break;
                        case 5:code.CreatStudents();
                            break;
                        case 6:code.StudentGroupListShow();
                            break;

                    }
                }
                
            } while (selection != 0);

        }
    }
}
