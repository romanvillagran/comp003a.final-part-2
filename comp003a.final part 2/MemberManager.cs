using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    
    public class MemberManager
    {
        // Public list to store members 
        public List<Member> Members = new List<Member>();

        // Method to add a member
        public void AddMember(Member member)
        {
            Members.Add(member); // Add the member to the list
            Console.WriteLine("Member added successfully");
        }
        
        // Method to view all members
        public void ViewMembers()
        {
            if (Members.Count == 0) // Check if the list is empty
            {
                Console.WriteLine("No members found");
                return;
            }

            for (int i = 0; i < Members.Count; i++) // Loop through the list
            {
                Console.WriteLine($"{i + 1}. Name: {Members[i].Name}, Age: {Members[i].Age}, Plan: {Members[i].Plan}");
            }
        }
        /// <summary>
        /// this updates a member
        /// </summary>
        /// <param name="name"></param>
        /// <param name="updatedMember"></param>
        public void UpdateMember(string name, Member updatedMember)
        {
            bool memberFound = false;

            for (int i = 0; i < Members.Count; i++)
            {
                if (Members[i].Name == name) // Check if this is the member we want to update
                {
                    Members[i] = updatedMember; // Update the member
                    memberFound = true;
                    break; // Exit the loop once we've found and updated the member
                }
            }

            if (memberFound)
            {
                Console.WriteLine("Member updated successfully");
            }
            else
            {
                Console.WriteLine("Member not found");
            }
        }
        /// <summary>
        /// this deletes a member
        /// </summary>
        /// <param name="name"></param>
        public void DeleteMember(string name)
        {
            bool memberFound = false;

            for (int i = 0; i < Members.Count; i++)
            {
                if (Members[i].Name == name) // Check if this is the member we want to delete
                {
                    Members.RemoveAt(i); // Remove the member
                    memberFound = true;
                    break; // Exit the loop once we've found and deleted the member
                }
            }

            if (memberFound)
            {
                Console.WriteLine("Member deleted successfully");
            }
            else
            {
                Console.WriteLine("Member not found");
            }
        }
       
    }
}
