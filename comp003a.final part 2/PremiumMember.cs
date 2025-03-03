using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public class PremiumMember : Member
    {
        public override string Plan { get; set; } = "Premium"; // Set plan to "Premium"

        //initialize a premium member
        public PremiumMember(string name, int age) : base(name, age) { }
    }
}
