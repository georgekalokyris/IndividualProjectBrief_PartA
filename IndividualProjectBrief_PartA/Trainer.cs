namespace IndividualProjectBrief_PartA
{
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
    
}
