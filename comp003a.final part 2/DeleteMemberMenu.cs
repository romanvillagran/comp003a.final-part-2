using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{

        public static class DeleteMemberMenu
        {
        /// <summary>
        /// this deletes members
        /// </summary>
        /// <param name="manager"></param>
            public static void DeleteMember(MemberManager manager)
            {
                Console.Write("Enter the name of the member to delete: "); // ask for who you want to delete
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Member name cannot be empty.");
                    return;
                }

                try
                {
                    manager.DeleteMember(name); // Delete the member from the list
                    Console.WriteLine("Member deleted successfully!");
                }
                catch (KeyNotFoundException ex)
                {
                    // 
                    Console.WriteLine($"Member '{name}' not found");
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"Error");
                }
            }
        }
    }
