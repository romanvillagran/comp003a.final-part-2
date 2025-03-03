using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public abstract class Member
    {
        // Private fields
        private string _name;
        private int _age;

        public string Name // Public property for name
        {
            get => _name; // Get name
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // Validate that name is not empty
                    throw new ArgumentException("Name cannot be empty.");
                _name = value; // Set the name
            }
        }

        public int Age // Public property for age
        {
            get => _age; // Getter for age
            set
            {
                if (value <= 0) // Validate that age is greater than 0
                    throw new ArgumentException("Age must be greater than 0.");
                _age = value; 
            }
        }

        public abstract string Plan { get; set; }

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Plan: {Plan}";
        }
    }
}
