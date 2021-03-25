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
            return $"Firstname: {FirstName}, Lastname: {LastName}, Date of birth: {DateOfBirth}, Tuition Fees: {Fees}£";
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

            //Top Menu
            Console.WriteLine("\n Please Select an option to continue");
            Console.WriteLine("Press 1 for Data Modification");
            Console.WriteLine("Press 2 for Data Presentation");
            Console.WriteLine("Press 3 for Deadline Assignment Checks");

            switch (Console.ReadLine())
            {
                case "1":
                    DataManipulation(PeopleCert);
                    
                    break;
                case "2":
                    DataPresentation();
                    break;
                case "3":
                    DeadlineCheck();
                    break;
                default:
                    break;

            }


        }

       

        private static void DataPresentation()
        {
            Console.WriteLine("Please select the type of object that you would like to preview");
        }

        private static void DataManipulation(School PeopleCert)
        {
            //Menu 1
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
        }
        private static void ManualData(School PeopleCert)
        {

            Console.WriteLine("Option 2 Selected - Please select the table that you would like to populate");
            Console.WriteLine("Press 1 for Students");
            Console.WriteLine("Press 2 for Trainers");
            Console.WriteLine("Press 3 for Assignments");
            Console.WriteLine("Press 4 for Courses");

            switch(Console.ReadLine())
            {
                case "1":
                    AddStudents();
                    break;
                case "2":
                    AddTrainers();
                    break;
                case "3":
                    AddAssignents();
                    break;
                case "4":
                    AddCourses();
                    break;
                default:
                    break;
            }

            void AddStudents()
            {
                Console.WriteLine("Adding Students");
                Console.WriteLine("Please enter the student's First Name");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Please enter the student's Last Name");
                string LastName = Console.ReadLine();

                Console.WriteLine("Please enter the student's dateOfBirth");
                DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Please enter the amount of the total tuitionFees");
                int Fees = int.Parse(Console.ReadLine());

                
                PeopleCert.Students.Add(new Student(FirstName, LastName, DateOfBirth, Fees));

                var LastStudent = PeopleCert.Students.Last();
                
                Console.WriteLine(LastStudent);
                
                    
            }

            void AddTrainers()
            {
                Console.WriteLine("Adding Trainers");
            }

            void AddAssignents()
            {
                Console.WriteLine("Adding Assignments");
            }

            void AddCourses()
            {
                Console.WriteLine("Adding Course");
            }

        }
        private static void DeadlineCheck()
        {
            Console.WriteLine("DeadLine Check");
        }






    }

}
