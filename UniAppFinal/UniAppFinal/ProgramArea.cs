using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppFinal
{
    class ProgramArea
    {
        public int Id { get; private set; }
        public string ProgramName { get; set; }
        public List<Teacher> Teachers { get; set; }
        public static int ProgramId = 1;
        public List<ProgSpecification> ProgSpecifications { get; set; }
        public ProgramArea(string ProgramName)
        {
            this.ProgramName = ProgramName;
            Id = ProgramId;
            Teachers = new List<Teacher>();
            ProgramId++;
            ProgSpecifications = new List<ProgSpecification>();
        }
        public static void AddProgram()
        {
            Console.WriteLine("Program name");
            string programName = Console.ReadLine();
            ProgramArea prog = new ProgramArea(programName);
            Console.WriteLine("Program was created successfully");
            AllLists.ProgramAreas.Add(prog);
        }

        public static void ShowProgram()
        {
            foreach (var programArea in AllLists.ProgramAreas)
            {
                Console.WriteLine("Program id: {0}, Program name: {1}", programArea.Id, programArea.ProgramName);
            }
            Console.Write("Select program by id: ");
            string programId = Console.ReadLine();
            ProgramArea SelectedProgram = null;
            int prgId;
            if (int.TryParse(programId, out prgId))
            {
                bool correctProgram = false;
                foreach (var programArea in AllLists.ProgramAreas)
                {
                    if (programArea.Id == prgId)
                    {
                        correctProgram = true;
                        SelectedProgram = programArea;
                        break;
                    }
                }
                if (correctProgram)
                {
                    Console.Write("Write specification title: ");
                    string title = Console.ReadLine();
                    Console.Write("Write specification value: ");
                    string value = Console.ReadLine();
                    ProgSpecification newSpec = new ProgSpecification(title, value);
                    SelectedProgram.ProgSpecifications.Add(newSpec);
                    Console.WriteLine("This specification was added successfully");
                    foreach (var programArea in SelectedProgram.ProgSpecifications)
                    {
                        Console.WriteLine("Program title: {0}, Program value: {1}", programArea.Title, programArea.Value);
                    }
                }
            }
        }

        public static void ShowProgsWithSpec()
        {
            foreach (var programArea in AllLists.ProgramAreas)
            {
                Console.WriteLine("Program id: {0}, Program name: {1}", programArea.Id, programArea.ProgramName);
            }
            Console.Write("Select program by id: ");
            string programId = Console.ReadLine();
            ProgramArea SelectedProgram = null;
            int prgId;
            if (int.TryParse(programId, out prgId))
            {
                bool correctProgram = false;
                foreach (var programArea in AllLists.ProgramAreas)
                {
                    if (programArea.Id == prgId)
                    {
                        correctProgram = true;
                        SelectedProgram = programArea;
                        break;
                    }
                }
                if (correctProgram)
                {
                    Console.WriteLine("Selected program name: {0} ", SelectedProgram.ProgramName);
                    foreach (var programArea in SelectedProgram.ProgSpecifications)
                    {
                        Console.WriteLine("Program title: {0}, Program value: {1}", programArea.Title, programArea.Value);
                    }
                }
            }
        }
    }
}
