using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectBrief_PartA
{
    class Course
    {
        //Private fields
        private string _title;

        private string _stream;

        private string _type;

        private DateTime _start_date;

        private DateTime _end_date;

        //Public properties
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _start_date;
            }
            set
            {
                _start_date = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return _end_date;
            }
            set
            {
                _end_date = value;
            }
        }

        //Each course can have multiple trainers
        public List<Trainer> Trains = new List<Trainer>();
        //Each course can have multiple students
        public List<Student> Studs = new List<Student>();
        //Each course can have multiple assignments
        public List<Assignment> Assigns = new List<Assignment>();

        public Course(string Title, string Stream, string Type, DateTime Start_Date, DateTime End_Date)
        {
            this.Title = Title;
            this.Stream = Stream;
            this.Type = Type;
            this.StartDate = Start_Date;
            this.EndDate = End_Date;
        }

        public override string ToString()
        {
            return $"Title: {_title}, Stream: {_stream}, Type: {_type}, Start Date: {_start_date.ToString("dd/MM/yyyy")}, End Date: {_end_date.ToString("dd/MM/yyyy")}";
        }
    }

    class Trainer
    {
        //Private fields
        private string _firstName;

        private string _lastName;

        private string _subject;

        //Public properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }

        public Trainer(string FirstName, string LastName, string Subject)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Subject = Subject;
        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}, Lastname: {_lastName}, Subject: {_subject}";
        }


    }




    class Student
    {
        //Private fields
        private string _firstName;

        private string _lastName;

        private DateTime _dateOfBirth;

        private int _tuitionFees;


        //Public properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public int Fees
        {
            get
            {
                return _tuitionFees;
            }
            set
            {
                _tuitionFees = value;
            }
        }

        public Student(string FirstName, string LastName, DateTime DateOfBirth, int Fees)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Fees = Fees;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}, Lastname: {_lastName}, Date of birth: {_dateOfBirth.ToString("dd/MM/yyyy")}, Tuition Fees: {_tuitionFees}$";
        }
    }


    class Assignment
    {
        //Private fields
        private string _title;

        private string _description;

        private DateTime _subDateTime;

        private int _oralMark;

        private int _totalMark;

        //Public properties
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public DateTime SubDateTime
        {
            get
            {
                return _subDateTime;
            }
            set
            {
                _subDateTime = value;
            }
        }

        public int OralMark
        {
            get
            {
                return _oralMark;
            }
            set
            {
                _oralMark = value;
            }
        }

        public int TotalMark
        {
            get
            {
                return _totalMark;
            }
            set
            {
                _totalMark = value;
            }

        }

        public Assignment(string Title, string Description, DateTime SubDateTime, int OralMark, int TotalMark)
        {
            this.Title = Title;
            this.Description = Description;
            this.SubDateTime = SubDateTime;
            this.OralMark = OralMark;
            this.TotalMark = TotalMark;
        }

        public override string ToString()
        {
            return $"Title: {_title}, Description: {Description}, Submission Date:{_subDateTime.ToString("dd/MM/yyyy")}, OralMark: {_oralMark}, TotalMark: {_totalMark}";
        }

    }

    class School
    {
        public List<Student> Students = new List<Student>();

        public List<Trainer> Trainers = new List<Trainer>();

        public List<Assignment> Assignments = new List<Assignment>();

        public List<Course> Courses = new List<Course>();
       
    }

    class Program
    {

        static void Main(string[] args)
        {

            School PeopleCert = new School();


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
                        DataManipulation(PeopleCert);
                        break;
                    case "2":
                        DataPresentation(PeopleCert);
                        break;
                    case "3":
                        DeadlineCheck();
                        break;
                    case "x":
                        Console.WriteLine("Thank you for using the Student System");
                        ContM = false;
                        break;
                        Console.ReadKey();
                    default:
                        continue;
                }
            }
        }



        private static void DataPresentation(School PeopleCert)
        {
            bool ContPres = true;
            while (ContPres)
            {


                Console.WriteLine("Please select the type of object that you would like to preview");

                Console.WriteLine("Press 1 to view the list of all students");
                Console.WriteLine("Press 2 to view the list of all trainers");
                Console.WriteLine("Press 3 to view the list of all assignments");
                Console.WriteLine("Press 4 to view the list of all courses");

                //Console.WriteLine("Press 5 to view the list of all students per course");
                //Console.WriteLine("Press 6 to view the list of all assignments per course");
                //Console.WriteLine("Press 7 to view the list of all assignments per student");
                //Console.WriteLine("Press 8 to view the list of students that belong to more than one course");

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
                    case "x":
                        ContPres = false;
                        break;
                }
            }

            void DataPreview(int n)
            {
                if (n == 1)
                {
                    foreach (var i in PeopleCert.Students)
                    {
                        Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{i}");
                    }
                }
                else if (n == 2)
                {
                    foreach (var i in PeopleCert.Trainers)
                    {   
                        
                        Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{i}");
                    }
                }
                else if (n == 3)
                {
                    foreach (var i in PeopleCert.Assignments)
                    {
                        Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{i}");
                    }
                }
                else if (n == 4)
                {
                    foreach (var i in PeopleCert.Courses)
                    {
                        Console.WriteLine($"-------------------------------------------------------------------------------------------------------- \n{i}");
                    }
                }
                else Console.WriteLine("No valid option selected");

                Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            }


        }

        private static void DataManipulation(School PeopleCert)
        {
            
            Console.WriteLine("Please select an option to continue");
            Console.WriteLine("Press 1 to use synthetic data");
            Console.WriteLine("Press 2 to manually enter data");
            Console.WriteLine("Press 3 to remove data");

            switch (Console.ReadLine())
            {
                case "1":
                    SyntheticData(PeopleCert);
                    break;
                case "2":
                    ManualData(PeopleCert);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

        }

        private static void SyntheticData(School PeopleCert)
        {
            Random s = new Random();
            Console.WriteLine("Option '1' Selected - Generating Synthetic Data");

            PeopleCert.Students.Add(new Student("George", "Kal", DateTime.Parse("19, 10, 1994"),s.Next(1000,2000)));
            PeopleCert.Students.Add(new Student("Giannis", "Pan", DateTime.Parse("10, 06, 1988"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Olia", "Mour", DateTime.Parse("07, 08, 1995"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Antonis", "Kat", DateTime.Parse("04, 11, 1994"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Nikos", "Xen", DateTime.Parse("18, 04, 1994"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Alex", "Kav", DateTime.Parse("16, 03, 1993"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Antreas", "Plev", DateTime.Parse("01, 09, 1992"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Anastasia", "Kalok", DateTime.Parse("24, 08, 1986"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Agapi", "Kalok", DateTime.Parse("16, 02, 1996"), s.Next(1000, 2000)));
            PeopleCert.Students.Add(new Student("Ilias", "Diam", DateTime.Parse("30, 10, 1990"), s.Next(1000, 2000)));
            
            Console.WriteLine($"\n{PeopleCert.Students.Count} records of Students added successfully!");

            PeopleCert.Trainers.Add(new Trainer("Michael", "Scott", "Project Management"));
            PeopleCert.Trainers.Add(new Trainer("Dwight", "Schrute", "Sales Management"));
            PeopleCert.Trainers.Add(new Trainer("Jim", "Halpert", "Object Oriented Programming"));
            PeopleCert.Trainers.Add(new Trainer("Creed", "Bratton", "Electronics and TeleCommunication Systems"));
            PeopleCert.Trainers.Add(new Trainer("Pam", "Beesly", "Computer Graphics"));
            PeopleCert.Trainers.Add(new Trainer("Darryl", "Philbin", "DBMS Systems"));
            PeopleCert.Trainers.Add(new Trainer("Stanley", "Hudson", "Operating Systems"));
            PeopleCert.Trainers.Add(new Trainer("Andy", "Bernard", "Computer Organisation & Architecture"));
            PeopleCert.Trainers.Add(new Trainer("Kevin", "Malone", "Systems Programming"));
            PeopleCert.Trainers.Add(new Trainer("Kelly", "Kapoor", "Logic, Discrete Mathematical Structures"));

            Console.WriteLine($"\n{PeopleCert.Trainers.Count} records of Trainers added successfully!");

            PeopleCert.Courses.Add(new Course("Adobe illustrator", "Graphics & Engineering Designing", "Design", DateTime.Parse("26,03,2021"),DateTime.Parse("26,03,2021")));
            PeopleCert.Courses.Add(new Course("Advanced Administration for Citrix", "Systems Engineering", "Virtual Machines",DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Fundamentals of Unix", "Systems Engineering", "Operation Systems", DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Microsoft Azure", "MS Engineering", "Cloud Technologies", DateTime.Parse("01,04,2021"), DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Oracle E-Business Suite", "Informatics", "CRM", DateTime.Parse("01,04,2021"), DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Dynamics of Information Security", "Security Engineering", "Security Technologies", DateTime.Parse("01,04,2021"), DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Systems Analysis", "Systems Analysis", "Systems Analytics",DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Digital Marketing", "Marketing", "Digital Marketing Engineering",DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Office 365", "Infrastructure", "IT Infrastructure", DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));
            PeopleCert.Courses.Add(new Course("Advanced Geographic Information Systems", "Information Systems", "Geographic Systems",DateTime.Parse("01,04,2021"),DateTime.Parse("30,09,2021")));

            Console.WriteLine($"\n{PeopleCert.Courses.Count} records of Courses added successfully!");

            PeopleCert.Assignments.Add(new Assignment("Gant-Chart", "Project Management", DateTime.Parse("26,03,2021"), 10, 90));
            PeopleCert.Assignments.Add(new Assignment("Budget Analysis", "Financial analysis of project", DateTime.Parse("26,03,2021"), 70, 30));
            PeopleCert.Assignments.Add(new Assignment("Class Diagram", "Programs class diagram", DateTime.Parse("26,03,2021"), 10, 90));
            PeopleCert.Assignments.Add(new Assignment("ERD Diagram", "Database diagram", DateTime.Parse("26,03,2021"), 10, 90));
            PeopleCert.Assignments.Add(new Assignment("Systems Analysis", "Systems analysis", DateTime.Parse("26,03,2021"), 40, 60));
            PeopleCert.Assignments.Add(new Assignment("Business Plan", "Presentation of the business plan", DateTime.Parse("26,03,2021"), 70, 30));
            PeopleCert.Assignments.Add(new Assignment("Bug Analysis", "Work item management - git", DateTime.Parse("26,03,2021"), 0, 100));
            PeopleCert.Assignments.Add(new Assignment("Software Develpment A", "Software Implementation Part A", DateTime.Parse("26,03,2021"), 0, 100));
            PeopleCert.Assignments.Add(new Assignment("Software Development B", "Software Implementation", DateTime.Parse("26,03,2021"), 0, 100));
            PeopleCert.Assignments.Add(new Assignment("QA Testing Methods", "Testing methodologies", DateTime.Parse("26,03,2021"), 0, 100));

            Console.WriteLine($"\n{PeopleCert.Assignments.Count} records of Assignments added successfully!");

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            
            //Assigning Students to Courses
            for (int i = 0; i <= 50; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Assigning Students to Courses: OK");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------");

                }

                int CourseRandom = s.Next(0, (PeopleCert.Courses.Count - 1));
                int StudentRandom = s.Next(0, (PeopleCert.Students.Count - 1));

                bool exists = PeopleCert.Courses[CourseRandom].Studs.Contains(PeopleCert.Students[StudentRandom]);

                if (!exists) //Check if the student exists already in course
                {
                    PeopleCert.Courses[CourseRandom].Studs.Add(PeopleCert.Students[StudentRandom]);
                }
                else continue;
                
            }

            //Assigning Τrainers to Courses
            for (int i = 0; i <= 50; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Assigning Students to Courses: OK");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------");

                }

                int CourseRandom = s.Next(0, (PeopleCert.Courses.Count - 1));
                int StudentRandom = s.Next(0, (PeopleCert.Students.Count - 1));

                bool exists = PeopleCert.Courses[CourseRandom].Studs.Contains(PeopleCert.Students[StudentRandom]);

                if (!exists) //Check if the student exists already in course
                {
                    PeopleCert.Courses[CourseRandom].Studs.Add(PeopleCert.Students[StudentRandom]);
                }
                else continue;

            }



            ////View all of the Students per Course
            //for (int i = 0; i < PeopleCert.Courses.Count - 1; i++)
            //{
            //    Console.WriteLine($"|Course title|: {PeopleCert.Courses[i].Title}");

            //    Console.Write("----------------");
            //    //Print a line equal to the size of the Course's Title
            //    for (int l = 0; l < PeopleCert.Courses[i].Title.Length; l++)
            //    {
            //        Console.Write("-");
            //    }

            //    for (int j = 0; j < PeopleCert.Courses[i].Studs.Count; j++)
            //    {

            //        Console.WriteLine($"\n|Student in course|: {PeopleCert.Courses[i].Studs[j]}");

            //    }
            //    Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            //}


        }
        private static void ManualData(School PeopleCert)
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


                    PeopleCert.Students.Add(new Student(FirstName, LastName, DateOfBirth, Fees));

                    var LastStudent = PeopleCert.Students.Last();
                    Console.WriteLine("\nRecord added: ");
                    Console.WriteLine(LastStudent);

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

                    PeopleCert.Trainers.Add(new Trainer(FirstName, LastName, Subject));

                    var LastTrainer = PeopleCert.Trainers.Last();
                    Console.WriteLine("\n Record added: ");
                    Console.WriteLine(LastTrainer);

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

                    PeopleCert.Assignments.Add(new Assignment(Title, Description, SubDateTime, OralMark, TotalMark));
                    var LastAssignment = PeopleCert.Assignments.Last();

                    Console.WriteLine("\n Record added: ");
                    Console.WriteLine(LastAssignment);

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

                    PeopleCert.Courses.Add(new Course(Title, Stream, Type, StartDate, EndDate));

                    var LastCourse = PeopleCert.Courses.Last();

                    Console.WriteLine("\n Record added: ");
                    Console.WriteLine(LastCourse);

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
        private static void DeadlineCheck()
                {
                    Console.WriteLine("DeadLine Check");
                }


            
        
    } 
}
