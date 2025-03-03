using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final_part_2
{
    public static class ViewMemberMenu
    {
        /// <summary>
        /// view members
        /// </summary>
        /// <param name="manager"></param>
        public static void ViewMember(MemberManager manager)
        {
            manager.ViewMembers(); // Call the ViewMembers method
        }
    }
}
