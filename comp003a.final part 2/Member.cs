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
        // Public fields
        public string Name;
        public int Age;
        public string Plan;

        // initialize a member
        public Member(string name, int age, string plan)
        {
            Name = name;
            Age = age;
            Plan = plan;
        }

        // display member details
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Plan: {Plan}");
        }
    }
}
