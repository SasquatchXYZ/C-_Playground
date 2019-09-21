using System;

namespace Program
{
    public class Employee
    {
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _firstName;

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        private string _lastName;
        public string Title { get; set; }
        public Employee Manager { get; set; }
        public string Salary { get; set; } = "Not Enough";

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }

//        public void SetName(string newFirstName, string newLastName)
//        {
//            this.FirstName = newFirstName;
//            this.LastName = newLastName;
//            Console.WriteLine($"Name changed to: {this.GetName()}");
//        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }
}