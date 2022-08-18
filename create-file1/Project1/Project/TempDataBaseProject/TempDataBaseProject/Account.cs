using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSystem
{
    internal class Account
    {
        private string username;
        private string password;

        public Account()
        {
            username = "";
            password = "";
        }

         public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

         public Account(Account ACC)
        {
            this.username = ACC.getUserName();
            this.password = ACC.getPassword();
        }

        public string getUserName()
        {
            return username;
        }

        public void setUserName(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}  