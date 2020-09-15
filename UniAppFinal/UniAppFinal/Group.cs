using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class Group
    {
        public int Id { get; private set; }
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher;
        private static int GroupId = 1;
        public Group(string GroupName,Teacher teacher)
        {
            this.GroupName = GroupName;
            Students = new List<Student>();
            Teacher = teacher;
            GroupId++;
            Id = GroupId;
        }
        public static void AddGroup()
        {
            Console.ResetColor();
            Console.WriteLine("________****________\n");
            Console.Write("Enter a group name:");
            string groupName = Console.ReadLine();
            Teacher newTeacher =Teacher.AddTeacher();
            Group group = new Group(groupName, newTeacher);
            Console.WriteLine("Group {0} was created successfully. Teacher's name: {1}",group.GroupName,group.Teacher.Firstname);
            AllLists.Groups.Add(group);
            ShowGroup();
        }

        public static void ShowGroup()
        {
            foreach (var group in AllLists.Groups)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Group Name: {0}, Teacher Name: {1}",group.GroupName,group.Teacher.Firstname);
            }
        }
    }
}
