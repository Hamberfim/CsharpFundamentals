using System;
using System.Data.SqlClient;

namespace ConnAdventureWorksEmployee
{
    class Program
    {

        static void Main(string[] args)
        {

            try 
            {
                // access is always either a user/pass or "integrated security"
                // if user/pass the connection string should be protected and provided via configuration
                // use environment variables that are protected via strict user-level access controls,
                // User Secrets (https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows)
                // or secure secret store Azure Key Vault Configuration
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";  // or server name
                //builder.UserID = "<username>";            
                //builder.Password = "<password>";
                builder.IntegratedSecurity = true;  // false for remote user auth rather than local NT auth.
                builder.InitialCatalog = "AdventureWorks";
                // Console.WriteLine(builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery AdventureWorks Employee Data:");
                    Console.WriteLine("=========================================\n");
                    Console.WriteLine("[FirstName] [LastName], \n[EmailAddress], [JobTitle]\n");
                    Console.WriteLine("=========================================\n");

                    // Query              index zero   index one   index two       index three
                    String sql = "SELECT [FirstName], [LastName], [EmailAddress], [JobTitle] FROM [AdventureWorks].[HumanResources].[vEmployee]";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine(" {0} {1} \n {2}, {3}\n", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                                Console.WriteLine($" {reader.GetString(0)} {reader.GetString(1)} \n {reader.GetString(2)}, {reader.GetString(3)}\n");
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n\n");
        }
    }
}
