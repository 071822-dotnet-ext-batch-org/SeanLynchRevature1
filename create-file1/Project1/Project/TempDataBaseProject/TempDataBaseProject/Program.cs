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
            System.Console.WriteLine("Testing");
            // string answer = "";
            // System.Console.WriteLine("Are you a new user? Yes or No");
            // answer=Console.ReadLine();
            // if (answer.ToLower() == "yes")
            // {
            //     createAccount();
            // }
            // else if (answer.ToLower() == "no")
            // {
            //     findAccount();
            // }
            // else
            // {
            //     System.Console.WriteLine("Not a valid answer, please try again");
            // }

            // Account account = new Account(username, password);
            connectToDataBase("Employee");
            //writeToDataBase();
            //dropTable("testTaqble");
            //createTable("Employee", "UserName varchar(255), Password varchar(255)");
            //queryDataBase("insert into Employee (UserName, Password) values ('testUserName', 'pass123')");
            Console.ReadLine();
        }

        public static void queryDataBase(String sql)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "seaneosserver.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            { 
                using (SqlCommand sCmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.WriteLine(reader.GetString(0));
                            System.Console.WriteLine(reader.GetString(1));
                        }
                    }
                }
            }
        }

        public static void connectToDataBase(string databseName)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "seaneosserver.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                String sql = "SELECT * from " + databseName;
                using (SqlCommand sCmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            System.Console.WriteLine(reader["UserName"]);
                            System.Console.WriteLine(reader["Password"]);
                        }
                    }
                }
            } 
        }

        public static void writeToDataBase()
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "seaneosserver.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                String sql = "insert into test (firstname,age)values(@firstname,@age)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@firstname", "Homer");
                    cmd.Parameters.AddWithValue("@age",45);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                } 
            }
            //connectToDataBase();
        }

        public static void createTable(string tableName, string colums)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "seaneosserver.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                String sql = "create table "+ tableName +"("+colums+")";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table: "+tableName+" created");
                    connection.Close();
                }
            }
        }

        public static void dropTable(string name)
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            //Connect to name
            conn.DataSource = "seaneosserver.database.windows.net";
            //Creditentals
            conn.UserID = "Seaneolynch";
            conn.Password = "Xeaneo2412$$";
            conn.InitialCatalog = "Expense_Reimbursement_System";
            System.Console.WriteLine("Testing connection");
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                String sql = "drop table "+name;
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table: "+name+" dropped.");
                    connection.Close();
                }
            }
        }

        public Account createAccount()
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

        public Account findAccount()
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