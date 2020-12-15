using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_17
{
    class Human
    {
        private string name;
        private string lastName;
        private string phone;
        private string country;
        private string age;
        private string gender= null;

        public Human(string name, string lastName, string phone, string country, string age)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
            Country = country;
            Age = age;
        }

        public Human()
        { }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Country { get => country; set => country = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
