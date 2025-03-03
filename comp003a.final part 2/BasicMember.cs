using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public class BasicMember : Member
    {
        public override string Plan { get; set; } = "Basic"; // Set plan to "Basic"

        //initialize a basic member
        public BasicMember(string name, int age) : base(name, age) { }
    }
}
