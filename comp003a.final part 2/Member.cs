using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public class Member
    {
        // Public fields (beginners often use public fields instead of properties)
        public string Name;
        public int Age;
        public string Plan;

        // Constructor to initialize a member
        public Member(string name, int age, string plan)
        {
            Name = name;
            Age = age;
            Plan = plan;
        }

        // Method to display member details
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Plan: {Plan}");
        }
    }
}
