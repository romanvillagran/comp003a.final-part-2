using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{

    public static class DeleteMemberMenu
    {
        public static void DeleteMember(MemberManager manager)
        {
            try
            {
                Console.Write("Enter the index of the member to delete: "); // ask for who you want to delete
                int index = int.Parse(Console.ReadLine());

                manager.DeleteMember(index); // Delete the member from the list
                Console.WriteLine("Member deleted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
