using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputInt;
            do
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("*****************\n");
                Console.WriteLine("Select one of the followings");
                Console.WriteLine("1.Create group and group list");
                Console.WriteLine("2.Add program");
                Console.WriteLine("3.Select program id and add specification");
                Console.WriteLine("4.Select the program for the group");
                Console.WriteLine("5.Add teacher and teacher list");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput,out userInputInt))
                {
                    switch (userInputInt)
                    {
                        case 1:
                            Group.AddGroup();
                            break;
                        case 2:
                            ProgramArea.AddProgram();
                            break;
                        case 3:
                            ProgramArea.ShowProgram();
                            break;
                        case 4:
                            ProgramArea.ShowProgsWithSpec();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWarning: You can not enter a letter!!!");
                }
            } while (true);
        }
    }
}
