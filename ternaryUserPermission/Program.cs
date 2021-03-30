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
                Console.WriteLine($" Welcome, Super {title}! User level {levelAccess}.");
            }

            if ((title == "Admin") && (Convert.ToInt32(levelAccess) < 5))
            {
                Console.WriteLine($" Welcome, {title}! User level {levelAccess}.");
            }

            if ((title == "Manager") && (Convert.ToInt32(levelAccess) >= 2))
            {
                Console.WriteLine($" Welcome, {title}! Contact an Admin for a user level higer than {levelAccess}.");
            }

            if ((title == "Manager") && (Convert.ToInt32(levelAccess) < 2))
            {
                Console.WriteLine($" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("========== Checking Access Level =========\n");
            // call the method above 
            accessPermissions("Admin", "5");
            accessPermissions("Admin", "4");
            accessPermissions("Manager", "3");
            accessPermissions("Manager", "1");
            Console.WriteLine();

            // as a ternary
            string title = "Admin";
            int levelAccess = 6;
            string superAdmin = (title == "Admin") && (levelAccess == 6) ? $" Welcome Super {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(superAdmin);

            title = "Admin";
            levelAccess = 5;
            string midAdmin = (title == "Admin") && (levelAccess >= 4) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(midAdmin);

            title = "Admin";
            levelAccess = 3;
            string lowLeveladmin = (title == "Admin") && (levelAccess >= 4) ? $" Welcome Super {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(lowLeveladmin);

            title = "Manager";
            levelAccess = 4;
            string manager = (title == "Manager") && (levelAccess >= 4) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(manager);

            title = "Manager";
            levelAccess = 2;
            string lowLevelManager = (title == "Manager") && (levelAccess >= 3) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(lowLevelManager);
            Console.WriteLine();

            // check for level 5+ first - ternary
            title = "Admin";
            levelAccess = 6;
            string adminResult = levelAccess >= 5 ? $" Level {levelAccess} access is Authorized as Super Admin." : (title == "Admin") && (levelAccess >= 4) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(adminResult);

            title = "Admin";
            levelAccess = 4;
            string lowAdminResult = levelAccess >= 5 ? $" Level {levelAccess} access is Authorized as Super Admin." : (title == "Admin") && (levelAccess >= 4) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(lowAdminResult);

            title = "Manager";
            levelAccess = 3;
            string managerResult = levelAccess >= 5 ? $"{levelAccess} Access level is Authorized Super Admin." : (title == "Manager") && (levelAccess >= 3) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(managerResult);

            title = "Manager";
            levelAccess = 2;
            string lowManagerResult = levelAccess >= 5 ? $"{levelAccess} Access level is Authorized Super Admin." : (title == "Manager") && (levelAccess >= 3) ? $" Welcome {title}! User level {levelAccess}." : $" {title} Not Authorized. You do not have sufficient privileges at level {levelAccess}.";
            Console.WriteLine(lowManagerResult);

            Console.WriteLine("\n\n");
        }

        
    }
}
