using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Declan_test;";

            string insertStmt = "INSERT INTO dbo.Families(first_name, last_name) " +
                                "VALUES(@first_name, @last_name)";

            Console.WriteLine("Type your first name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Type your last name :");
            string lastName = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertStmt, conn))
            {
                // set up the command's parameters
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 100).Value = firstName;
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 50).Value = lastName;

                // open connection, execute command, close connection
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine("New row inserted");
                Console.ReadLine();
            }
        }
    }
}
