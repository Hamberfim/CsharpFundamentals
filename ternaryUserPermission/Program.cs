using System;

namespace ternaryUserPermission
{
    class Program
    {

        private static void accessPermissions(string title, string levelAccess)
        {
            // access by title and permission level
            if ((title == "Admin") && (Convert.ToInt32(levelAccess) >= 5))
            {
                Console.WriteLine($"Welcome, Super {title}! User level {levelAccess}.");
            }

            if ((title == "Admin") && (Convert.ToInt32(levelAccess) < 5))
            {
                Console.WriteLine($"Welcome, {title}! User level {levelAccess}.");
            }

            if ((title == "Manager") && (Convert.ToInt32(levelAccess) >= 2))
            {
                Console.WriteLine($"Welcome, {title}! Contact an Admin for a user level higer than {levelAccess}.");
            }

            if ((title == "Manager") && (Convert.ToInt32(levelAccess) < 2))
            {
                Console.WriteLine($"{title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.");
            }
        }
        

        static void Main(string[] args)
        {
            accessPermissions("Admin", "5");
            accessPermissions("Admin", "4");
            accessPermissions("Manager", "3");
            accessPermissions("Manager", "1");


            Console.WriteLine("\n\n");
        }

        
    }
}
