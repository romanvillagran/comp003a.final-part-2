using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public static class AddMemberMenu
    {
        public static void AddMember(MemberManager manager)
        {
            try
            {
                Console.Write("Enter the member's name: "); // Prompt for name
                string name = Console.ReadLine(); // Read name
                
                // Check if the name is null or empty
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty");
                    return; 
                }


                Console.Write("Enter the member's age: "); // Prompt for age
                int age = int.Parse(Console.ReadLine()); // Read age
                Console.Write("Enter the member's plan (Basic/Premium): "); // Prompt for plan
                string plan = Console.ReadLine(); // Read plan

                // Check if the plan is valid
                if (plan != "Basic" && plan != "Premium")
                {
                    Console.WriteLine("Invalid plan. Must be 'Basic' or 'Premium'.");
                    return;
                }

                // Create a new member and add it to the list
                Member newMember = new Member(name, age, plan);
                manager.AddMember(newMember);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
