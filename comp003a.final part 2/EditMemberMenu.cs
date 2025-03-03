using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public static class EditMemberMenu
    {
        /// <summary>
        /// this edits/updates a member
        /// </summary>
        /// <param name="manager"></param>
        public static void EditMember(MemberManager manager)
        {
            try
            {
                Console.Write("Enter the name of the member to update: ");
                string name = Console.ReadLine();

                // Check if the name is null or empty
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    return;
                }


                // Prompt for new name
                Console.Write("Enter the new name: ");
                string newName = Console.ReadLine();

                // Check if the new name is empty
                if (newName == "")
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    return;
                }

                // Prompt for new age
                Console.Write("Enter the new age: ");
                int newAge = int.Parse(Console.ReadLine());

                // Check if the age is valid
                if (newAge <= 0)
                {
                    Console.WriteLine("Age must be greater than 0.");
                    return;
                }

                // Prompt for new plan
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
                manager.UpdateMember(name, updatedMember);
                Console.WriteLine("Member updated successfully!"); 
            }
            catch (Exception ex) // Handle errors
            {
                Console.WriteLine($"Error try again");
            }
        }
    }
}
