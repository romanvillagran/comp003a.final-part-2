namespace comp003a.final_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberManager manager = new MemberManager(); // Create a new MemberManager object

            while (true) // Keep the program running
            {
                // Display the main menu
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. View Members");
                Console.WriteLine("3. Edit Member");
                Console.WriteLine("4. Delete Member");
                Console.WriteLine("5. Exit");
                Console.Write("Enter a number (1-5): ");

                string choice = Console.ReadLine(); // Read the user's choice

                switch (choice)
                {
                    case "1":
                        AddMemberMenu.AddMember(manager); // Call the AddMember method
                        break;
                    case "2":
                        ViewMemberMenu.ViewMembers(manager); // Call the ViewMembers method
                        break;
                    case "3":
                        EditMemberMenu.EditMember(manager); // Call the EditMember method
                        break;
                    case "4":
                        DeleteMemberMenu.DeleteMember(manager); // Call the DeleteMember method
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!"); 
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again."); 
                        break;
                }
            }
        }
    }
}
