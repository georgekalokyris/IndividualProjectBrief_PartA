using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectBrief_PartA
{
    class Program
    {
        private static School school = new School();
        private static Manager manager = new Manager(school);

        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("Welcome to Peoplecert's Student System");

            bool ContM = true;
            while (ContM)
            {
                //Top Menu
                Console.WriteLine("\nPlease Select an option to continue");
                Console.WriteLine("\nPress 1 for Data Modification");
                Console.WriteLine("Press 2 for Data Presentation");
                Console.WriteLine("Press 3 for Deadline Assignment Checks");
                Console.WriteLine("Press x key to exit");


                switch (Console.ReadLine())
                {
                    case "1":
                        DataManipulation();
                        break;
                    case "2":
                        DataPresentation();
                        break;
                    case "3":
                        DeadlineCheck();
                        break;
                    case "x":
                        Console.WriteLine("Thank you for using the Student System");
                        ContM = false;
                        break;
                    default:
                        continue;
                }
            }
        }

        internal static void DataPresentation()
        {
            bool ContPres = true;
            while (ContPres)
            {

                Console.WriteLine("Please select the type of object that you would like to preview");

                Console.WriteLine("Press 1 to view the list of all students");
                Console.WriteLine("Press 2 to view the list of all trainers");
                Console.WriteLine("Press 3 to view the list of all assignments");
                Console.WriteLine("Press 4 to view the list of all courses");
                Console.WriteLine("Press 5 to view the list of all students per course");
                Console.WriteLine("Press 6 to view the list of all trainers per course");
                Console.WriteLine("Press 7 to view the list of all assignments per course");
                Console.WriteLine("Press 8 to view the list of all assignments per student");
                Console.WriteLine("Press 9 to view the list of students that belong to more than one course");

                Console.WriteLine("Press x to return to the previous menu");

                switch (Console.ReadLine())
                {
                    case "1":
                        DataPreview(1);
                        ContPres = true;
                        continue;
                    case "2":
                        DataPreview(2);
                        break;
                    case "3":
                        DataPreview(3);
                        break;
                    case "4":
                        DataPreview(4);
                        break;
                    case "5":
                        DataPreview(5);
                        break;
                    case "6":
                        DataPreview(6);
                        break;
                    case "7":
                        DataPreview(7);
                        break;
                    case "8":
                        DataPreview(8);
                        break;
                    case "9":
                        DataPreview(9);
                        break;
                    case "x":
                        ContPres = false;
                        break;
                }
            }
        }
        static void DataPreview(int n)
        {
            if (n == 1)
            {
                foreach (var i in school.Students)
                {
                    Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{school.Students.IndexOf(i)}.{i}");
                }
            }
            else if (n == 2)
            {
                foreach (var i in school.Trainers)
                {

                    Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{school.Trainers.IndexOf(i)}.{i}");
                }
            }
            else if (n == 3)
            {
                foreach (var i in school.Assignments)
                {
                    Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{school.Assignments.IndexOf(i)}.{i}");
                }
            }
            else if (n == 4)
            {
                foreach (var i in school.Courses)
                {
                    Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{school.Courses.IndexOf(i)}.{i}");
                }
            }
            else if (n == 5)
            {
                //View all of the Students per Course
                for (int i = 0; i < school.Courses.Count; i++)
                {
                    Console.WriteLine($"|Course title|: {school.Courses[i].Title}");

                    Console.Write("----------------");
                    //Print a line equal to the size of the Course's Title
                    for (int l = 0; l < school.Courses[i].Title.Length; l++)
                    {
                        Console.Write("-");
                    }

                    for (int j = 0; j < school.Courses[i].Studs.Count; j++)
                    {

                        Console.WriteLine($"\n|Student in course|: {school.Courses[i].Studs[j]}");

                    }
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                }
            }
            else if (n == 6)
            {
                //View all of the Trainers per Course
                for (int i = 0; i < school.Courses.Count; i++)
                {
                    Console.WriteLine($"|Course title|: {school.Courses[i].Title}");

                    Console.Write("----------------");
                    //Print a line equal to the size of the Course's Title
                    for (int l = 0; l < school.Courses[i].Title.Length; l++)
                    {
                        Console.Write("-");
                    }

                    for (int j = 0; j < school.Courses[i].Trains.Count; j++)
                    {

                        Console.WriteLine($"\n|Trainer in course|: {school.Courses[i].Trains[j]}");

                    }
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                }

            }
            else if (n == 7)
            {
                //View all of the Assignments per Course
                for (int i = 0; i < school.Courses.Count; i++)
                {
                    Console.WriteLine($"|Course title|: {school.Courses[i].Title}");

                    Console.Write("----------------");
                    //Print a line equal to the size of the Course's Title
                    for (int l = 0; l < school.Courses[i].Title.Length; l++)
                    {
                        Console.Write("-");
                    }

                    for (int j = 0; j < school.Courses[i].Assigns.Count; j++)
                    {

                        Console.WriteLine($"\n|Assignment in course|: {school.Courses[i].Assigns[j]}");

                    }
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                }
            }
            else if (n == 8)
            {

                //View all of the assignments per student
                for (int i = 0; i < school.Students.Count; i++) //Loop through the Students
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"|Student|: {school.Students[i]}");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                    for (int j = 0; j < school.Students[i].StudAss.Count; j++)
                    {
                        Console.WriteLine($"|Assignment|:{school.Students[i].StudAss[j]}");
                    }
                }

            }
            else if (n == 9)
            {    //View all of students that are assigned to more than one course

                var students = school.Students.Where(x => x.StudCourse.Count > 1);
                Console.WriteLine("\t\tStudents that are assigned to more than once course");
                foreach(var student in students)
                {
                    Console.WriteLine($"|Student|:{student}");
                }

            }

            else Console.WriteLine("No valid option selected");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }


        private static void DataManipulation()
        {
            
            Console.WriteLine("Please select an option to continue");
            Console.WriteLine("Press 1 to use synthetic data");
            Console.WriteLine("Press 2 to manually enter data");
            Console.WriteLine("Press 3 to remove data");

            switch (Console.ReadLine())
            {
                case "1":
                    SyntheticData();
                    break;
                case "2":
                    ManualData();
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

        }

        private static void SyntheticData()
        {
            var s = new Random();
            Console.WriteLine("Option '1' Selected - Generating Synthetic Data");
            manager.AddStudent(new Student("George", "Kal",     new DateTime(1994, 10, 19), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Giannis", "Pan",    new DateTime(1988, 06, 10), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Olia", "Mour",      new DateTime(1995, 08, 07), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Antonis", "Kat",    new DateTime(1994, 11, 04), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Nikos", "Xen",      new DateTime(1994, 04, 18), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Alex", "Kav",       new DateTime(1993, 03, 16), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Antreas", "Plev",   new DateTime(1992, 09, 01), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Anastasia", "Kalok",new DateTime(1986, 08, 24), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Agapi", "Kalok",    new DateTime(1996, 02, 16), s.Next(1000, 2000)));
            manager.AddStudent(new Student("Ilias", "Diam",     new DateTime(1990, 10, 30), s.Next(1000, 2000)));

            Console.WriteLine($"\n{school.Students.Count} records of Students added successfully!");

            manager.AddTrainers(new Trainer("Michael", "Scott", "Project Management"));
            manager.AddTrainers(new Trainer("Dwight", "Schrute", "Sales Management"));
            manager.AddTrainers(new Trainer("Jim", "Halpert", "Object Oriented Programming"));
            manager.AddTrainers(new Trainer("Creed", "Bratton", "Electronics and TeleCommunication Systems"));
            manager.AddTrainers(new Trainer("Pam", "Beesly", "Computer Graphics"));
            manager.AddTrainers(new Trainer("Darryl", "Philbin", "DBMS Systems"));
            manager.AddTrainers(new Trainer("Stanley", "Hudson", "Operating Systems"));
            manager.AddTrainers(new Trainer("Andy", "Bernard", "Computer Organisation & Architecture"));
            manager.AddTrainers(new Trainer("Kevin", "Malone", "Systems Programming"));
            manager.AddTrainers(new Trainer("Kelly", "Kapoor", "Logic, Discrete Mathematical Structures"));

            Console.WriteLine($"\n{school.Trainers.Count} records of Trainers added successfully!");

            manager.AddCourse(new Course("Adobe illustrator", "Graphics & Engineering Designing", "Design",                      new DateTime(2021,03,26), new DateTime(2021,03,26)));
            manager.AddCourse(new Course("Advanced Administration for Citrix", "Systems Engineering", "Virtual Machines",        new DateTime(2021,04,23), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Fundamentals of Unix", "Systems Engineering", "Operation Systems",                     new DateTime(2021,04,25), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Microsoft Azure", "MS Engineering", "Cloud Technologies",                              new DateTime(2021,04,29), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Oracle E-Business Suite", "Informatics", "CRM",                                        new DateTime(2021,04,30), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Dynamics of Information Security", "Security Engineering", "Security Technologies",    new DateTime(2021,04,30), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Systems Analysis", "Systems Analysis", "Systems Analytics",                            new DateTime(2021,05,01), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Digital Marketing", "Marketing", "Digital Marketing Engineering",                      new DateTime(2021,06,01), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Office 365", "Infrastructure", "IT Infrastructure",                                    new DateTime(2021,07,01), new DateTime(2021,09,30)));
            manager.AddCourse(new Course("Advanced Geographic Information Systems", "Information Systems", "Geographic Systems", new DateTime(2021,08,01), new DateTime(2021,09,30)));

            Console.WriteLine($"\n{school.Courses.Count} records of Courses added successfully!");

            manager.AddAssignmentToCourse(new Assignment("Gant-Chart", "Project Management",                        new DateTime(2021,03,26), 10, 90), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Budget Analysis", "Financial analysis of project",        new DateTime(2021,03,26), 70, 30), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Class Diagram", "Programs class diagram",                 new DateTime(2021,03,26), 10, 90), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("ERD Diagram", "Database diagram",                         new DateTime(2021,03,26), 10, 90), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Systems Analysis", "Systems analysis",                    new DateTime(2021,03,26), 40, 60), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Business Plan", "Presentation of the business plan",      new DateTime(2021,03,26), 70, 30), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Bug Analysis", "Work item management - git",              new DateTime(2021,03,26), 0, 100), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Software Develpment A", "Software Implementation Part A", new DateTime(2021,03,26), 0, 100), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("Software Development B", "Software Implementation",       new DateTime(2021,03,26), 0, 100), school.Courses[s.Next(0, school.Courses.Count - 1)]);
            manager.AddAssignmentToCourse(new Assignment("QA Testing Methods", "Testing methodologies",             new DateTime(2021,03,26), 0, 100), school.Courses[s.Next(0, school.Courses.Count - 1)]);

            Console.WriteLine($"\n{school.Assignments.Count} records of Assignments added successfully!");

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Assigning Assignments to Courses: OK");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            //Assigning Students to Courses
            for (int i = 0; i <= 50; i++)
            {
                
                int courseRandom = s.Next(0, (school.Courses.Count - 1));
                int StudentRandom = s.Next(0, (school.Students.Count - 1));

                var course = school.Courses[courseRandom];
                var student = school.Students[StudentRandom];

                manager.AddStudentToCourse(student, course);
   
            }

            Console.WriteLine("Assigning Students to Courses: OK");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            //Assigning Τrainers to Courses
            for (int i = 0; i < 50; i++)
            {
              
                int CourseRandom = s.Next(0, (school.Courses.Count - 1));
                int TrainerRandom = s.Next(0, (school.Trainers.Count - 1));

                var course = school.Courses[CourseRandom];
                var trainer = school.Trainers[TrainerRandom];

                if (course.Trains.Count < 2) //Check if the trainer exists already in course. If it doesn't exist and the course has less than 3 trainers add it
                {

                    manager.AddTrainerToCourse(trainer, course);

                }
            }
            Console.WriteLine("Assigning Trainers to Courses: OK");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");          
        }

        private static void ManualData()
        {
            Console.WriteLine("Option '2' Selected - Manual Data Input");
            bool ContM2 = true;
            while (ContM2)
            {
                Console.WriteLine("Please select the table that you would like to populate");
                Console.WriteLine("\nPress 1 for Students");
                Console.WriteLine("Press 2 for Trainers");
                Console.WriteLine("Press 3 for Assignments");
                Console.WriteLine("Press 4 for Courses");
                Console.WriteLine("Press x to return to the Main Menu");


                switch (Console.ReadLine())
                {
                    case "1":
                        AddStudents();
                        ContM2 = true;
                        continue;
                    case "2":
                        AddTrainers();
                        ContM2 = true;
                        continue;
                    case "3":
                        AddAssignents();
                        ContM2 = true;
                        continue;
                    case "4":
                        AddCourses();
                        ContM2 = true;
                        continue;
                    case "x":
                        ContM2 = false;
                        break;
                    default:
                        continue;
                }

            }

            void AddStudents()
            {
                bool ContS = true;
                while (ContS)
                {
                    Console.WriteLine("Adding Students");
                    Console.WriteLine("Please enter the student's first name");
                    string FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter the student's last name");
                    string LastName = Console.ReadLine();

                    Console.WriteLine("Please enter the student's dateOfBirth");
                    DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please enter the amount of the total tuitionFees");
                    int Fees = int.Parse(Console.ReadLine());

                    var student = new Student(FirstName, LastName, DateOfBirth, Fees);
                    manager.AddStudent(student);

                    Console.WriteLine("\nRecord added: ");
                    Console.WriteLine(student);

                    Console.WriteLine("\n\nPress enter to continue adding records or 'x' to return to the top menu");

                    if (Console.ReadLine() == "x")
                    {
                        ContS = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            void AddTrainers()
            {
                bool ContT = true;
                while (ContT)
                {
                    Console.WriteLine("Adding Trainers");

                    Console.WriteLine("Please enter the trainer's first name");
                    string FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter the trainer's last name");
                    string LastName = Console.ReadLine();

                    Console.WriteLine("Please enter the trainer's subject");
                    string Subject = Console.ReadLine();

                    var trainer = new Trainer(FirstName, LastName, Subject);
                    manager.AddTrainers(trainer);

                    Course course = PickCourseOptions();

                    manager.AddTrainerToCourse(trainer, course);
                    Console.WriteLine("\n Record added: ");
                    Console.WriteLine(trainer);

                    Console.WriteLine("\n\nPress enter to continue adding records or 'x' to return to the top menu");

                    if (Console.ReadLine() == "x")
                    {
                        ContT = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            void AddAssignents()
            {
                bool ContA = true;
                while (ContA)
                {
                    Console.WriteLine("Adding Assignments");
                    Console.WriteLine("Please enter the title of the Assignment");
                    string Title = Console.ReadLine();

                    Console.WriteLine("Please enter the description of the Assignment");
                    string Description = Console.ReadLine();

                    Console.WriteLine("Please enter the Assignment's final submission date");
                    DateTime SubDateTime = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please enter the Assignments oral mark");
                    int OralMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the Assignments total mark");
                    int TotalMark = Convert.ToInt32(Console.ReadLine());

                    Course course = PickCourseOptions();

                    var assignment = new Assignment(Title, Description, SubDateTime, OralMark, TotalMark);
                    if (manager.AddAssignmentToCourse(assignment, course))
                    {
                        Console.WriteLine($"\n Record added: {assignment} to course {course}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Assignment is already in course");
                    }

                    Console.WriteLine("\n\nPress enter to continue adding records or 'x' to return to the top menu");

                    if (Console.ReadLine() == "x")
                    {
                        ContA = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            void AddCourses()
            {
                bool ContC = true;
                while (ContC)
                {
                    Console.WriteLine("Adding Course");

                    Console.WriteLine("Please enter the title of the Course");
                    string Title = Console.ReadLine();

                    Console.WriteLine("Please enter the stream of the Course");
                    string Stream = Console.ReadLine();

                    Console.WriteLine("Please enter the type of the Course");
                    string Type = Console.ReadLine();

                    Console.WriteLine("Please enter the course's starting date");
                    DateTime StartDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please enter teh courese's end date");
                    DateTime EndDate = Convert.ToDateTime(Console.ReadLine());

                    var newcourse = new Course(Title, Stream, Type, StartDate, EndDate);

                    manager.AddCourse(newcourse);

                    Console.WriteLine("\n Record added: ");
                    Console.WriteLine(newcourse);

                    Console.WriteLine("\n\nPress enter to continue adding records or 'x' to return to the top menu");

                    if (Console.ReadLine() == "x")
                    {
                        ContC = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private static Course PickCourseOptions()
        {
            
            DataPreview(4);
            Console.WriteLine("Please select a course to assign the assignment to");
            int indcourse = int.Parse(Console.ReadLine());
            var course = school.Courses[indcourse];
            return course;
        }

        private static void DeadlineCheck()
        {
            Console.WriteLine("Please provide a date to check");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            var students = manager.GetStudentDue(date, out var start, out var end);

            if (students.Any()) //Check if there is at least one student
            {
                Console.WriteLine($"\nThe students that are due to submit an assignment from [{start.ToShortDateString()}] to [{end.ToShortDateString()}] is:");

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine($"No students are due to submit an assignment from [{start.ToShortDateString()}] to [{end.ToShortDateString()}]" );
            }
        }
    }
}
