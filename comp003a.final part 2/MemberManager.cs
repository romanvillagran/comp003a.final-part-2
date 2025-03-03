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

        // Method to update a member
        public void UpdateMember(int index, Member updatedMember)
        {
            if (index < 0 || index >= Members.Count) // Check if the index is valid
            {
                Console.WriteLine("Invalid member");
                return;
            }

            Members[index] = updatedMember; // Update the member
            Console.WriteLine("Member updated successfully");
        }

        // Method to delete a member
        public void DeleteMember(int index)
        {
            if (index < 0 || index >= Members.Count) // Check if the index is valid
            {
                Console.WriteLine("Invalid member");
                return;
            }

            Members.RemoveAt(index); // Remove the member
            Console.WriteLine("Member deleted successfully");
        }
    }
}
