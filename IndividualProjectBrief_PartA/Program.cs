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

        //Each course can have multiple students

        //Each course can have multiple assignments


        //Constructor

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
            Console.WriteLine("Please select the type of object that you would like to preview");

            Console.WriteLine("Press 1 to view the list of all students");
            Console.WriteLine("Press 2 to view the list of all trainers");
            Console.WriteLine("Press 3 to view the list of all assignments");
            Console.WriteLine("Press 4 to view the list of all courses");

            //Console.WriteLine("Press 5 to view the list of all students per course");
            //Console.WriteLine("Press 6 to view the list of all assignments per course");
            //Console.WriteLine("Press 7 to view the list of all assignments per student");
            //Console.WriteLine("Press 8 to view the list of students that belong to more than one course");

            switch (Console.ReadLine())
            {
                case "1":
                    DataPreview(1);
                    break;
                case "2":
                    DataPreview(2);
                    break;
                case "3":
                    DataPreview(3);
                    break;
                case "4":
                    DataPreview(4);
                    break;

            }

            void DataPreview(int n)
            {
                if (n == 1)
                {
                    foreach (var i in PeopleCert.Students)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (n == 2)
                {
                    foreach (var i in PeopleCert.Trainers)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (n == 3)
                {
                    foreach (var i in PeopleCert.Assignments) ;
                }
                else if (n == 4)
                {
                    foreach (var i in PeopleCert.Courses) ;
                }
                else Console.WriteLine("No valid option selected");






            }


        }

        private static void DataManipulation(School PeopleCert)
        {
            
            Console.WriteLine("Please select an option to continue");
            Console.WriteLine("Press 1 to user synthetic data");
            Console.WriteLine("Press 2 to manually enter data");

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
            Console.WriteLine("Option '1' Selected - Generating Synthetic Data");

            PeopleCert.Students.Add(new Student("George", "Kalokyris", DateTime.Parse("19, 10, 1994"),2000));


            




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
