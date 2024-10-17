using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProjectStudentManagment
{
    internal class StudentManager
    {
        private readonly IStorageServices _storageServices;
        public StudentManager (IStorageServices storageServices)
        {
            _storageServices = storageServices;
        }
        public void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("Registration Number: ");
            student.RegNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter Standard");
            student.Standard = Console.ReadLine();

            Console.WriteLine("Enter Phone NUmber");
            student.PhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Student status: 1.Promoted 2.Demoted");

            var studentStatus = Console.ReadLine();
            student.StudentStatus = studentStatus == "1" ? StudentStatus.Promoted : StudentStatus.Demoted;
            _storageServices.Save(student);
        }
        public void RemoveStudent()
        {

        }
        public void UpdateStudent()
        {

        }
        public void SearchStudent()
        {

        }
        public void Exit()
        {

        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Search Student");
                Console.WriteLine("5. Exit");

                var options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        AddStudent();
                        break;
                        case "2":
                        RemoveStudent();
                        break;
                        case "3":
                        UpdateStudent();
                        break;
                        case "4":
                        UpdateStudent();
                        break;
                        case "5":
                        Exit();
                        break;  
                        default:
                        Console.WriteLine("INvalid Option");
                        break;



                }
            }
        }
    }

}
