using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Testing");
            //string answer = "";
            //System.Console.WriteLine("Are you a new user? Yes or No");
            //answer = Console.ReadLine();
            //if (answer.ToLower() == "yes")
            //{
            //    createAccount();
            //}
            //else if (answer.ToLower() == "no")
            //{
            //    findAccount();
            //}
            //else
            //{
            //    System.Console.WriteLine("Not a valid answer, please try again");
            //}

            //Account account = new Account(username, password);
            connectToDataBase();
        }

        public static void connectToDataBase()
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "SQL_databases.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                String sql = "SELECT * from test";
                using (SqlCommand sCmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            System.Console.WriteLine(reader["UserName"].ToString());
                            System.Console.WriteLine(reader["Password"].ToString());
                        }
                    }
                }
            } 
        }

        public static Account createAccount()
        {
            string username = "";
            string password = "";
            System.Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            System.Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            //create and store an account in the database here
            return new Account(username, password);

        }

        public static Account findAccount()
        {
            string username = "";
            string password = "";
            System.Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            System.Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            //search for account in database here
            return new Account(username, password);

        }
    }
} 