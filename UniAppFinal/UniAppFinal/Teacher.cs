using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class Teacher
    {
        public int Id { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkExperience { get; set; }
        public List<Group> Groups { get; set; }
        public static int TeacherId = 1;
        public Teacher(string Firstname, string Lastname, string Email, string Phone, int WorkExperience)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Phone = Phone;
            this.WorkExperience = WorkExperience;
            TeacherId++;
            Id = TeacherId;
            Groups = new List<Group>();
        }
        public static Teacher AddTeacher()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Add a teacher to the group.\n-Teacher's Firstname: ");
            string teacherFirstname = Console.ReadLine();
            Console.Write("\n-Teacher's Lastname: ");
            string teacherLastname = Console.ReadLine();
            Console.Write("\n-Teacher's Email: ");
            string teacherEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n-Teacher's Phone: ");
            string teacherPhone = Console.ReadLine();
            Console.Write("\n-Teacher's Experience (ex: year[1,2,3,...]) : ");
            string teacherExperience = Console.ReadLine();

            if (int.TryParse(teacherPhone,out int teacherPhoneInt) &&
                int.TryParse(teacherExperience,out int expInt))
            {
                Teacher teacher = new Teacher(teacherFirstname, teacherLastname, teacherEmail, teacherPhone, expInt);
                return teacher;
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
