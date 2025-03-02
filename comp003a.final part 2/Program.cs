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

               
            }
        }
    }
}
