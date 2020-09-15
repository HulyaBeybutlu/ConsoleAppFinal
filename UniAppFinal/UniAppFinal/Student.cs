using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class Student
    {
        public int Id { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkExperience { get; set; }
        public List<int> Valuation{ get; set; }
        public Group Group;
        public static int StuId = 1;
        public Student(string Firstname, string Lastname, string Email, string Phone, int WorkExperience,Group group)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Phone = Phone;
            this.WorkExperience = WorkExperience;
            Group = group;
            StuId++;
            Id = StuId;
            
        }
        public static void AddStudent()
        {
            Console.Write("Enter group id: ");
            Group selectedGroup = Group.AddGroup();
            Console.Write("Add a student to the group.\n-Student's Firstname: ");
            string studentFirstname = Console.ReadLine();
            Console.Write("\n-Student's Lastname: ");
            string studentLastname = Console.ReadLine();
            Console.Write("\n-Student's Email: ");
            string studentEmail = Console.ReadLine();
            Console.Write("\n-Student's Phone: ");
            string studentPhone = Console.ReadLine();
            Console.Write("\n-Student's Experience (ex: year[1,2,3,...]) : ");
            string studentExperience = Console.ReadLine();

            if (int.TryParse(studentPhone, out int stuPhoneInt) &&
                int.TryParse(studentExperience, out int stuExpInt))
            {
                Student stu = new Student(studentFirstname, studentLastname, studentEmail, studentPhone, stuExpInt, selectedGroup);
                return stu;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nWarning: Phone or Experience is not a number");
                return null;
            }
        }
    }
}
