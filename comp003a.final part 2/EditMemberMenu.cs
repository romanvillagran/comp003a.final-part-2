using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public static class EditMemberMenu
    {
        public static void EditMember(MemberManager manager)
        {
            try
            {
                Console.Write("Enter the name of the member to update: "); 
                int index = int.Parse(Console.ReadLine()); 

                Console.Write("Enter the new name: "); 
                string newName = Console.ReadLine(); 
                Console.Write("Enter the new age: ");
                int newAge = int.Parse(Console.ReadLine()); 
                Console.Write("Enter the new plan (Basic/Premium): "); 
                string newPlan = Console.ReadLine(); 

                // Check if the plan is valid
                if (newPlan != "Basic" && newPlan != "Premium")
                {
                    Console.WriteLine("Invalid plan. Must be 'Basic' or 'Premium'.");
                    return;
                }

                // Create an updated member and update the list
                Member updatedMember = new Member(newName, newAge, newPlan);
                manager.UpdateMember(index, updatedMember);
                Console.WriteLine("Member updated successfully"); // Display success message
            }
            catch (Exception ex) // Handle errors
            {
                Console.WriteLine($"Error: {ex.Message}");// error message
            }
        }
    }
}
