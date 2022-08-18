using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSystem
{
    internal class Reimbursement
    {
           private double amount;
           private string description;
           public Reimbursement()
           {
            amount = 0;
            description = "";
           }

           public Reimbursement(double amount, string description)
           {
            amount = 0;
            description = "";
           }

           private void setAmount(double amount)
           {
            this.amount = amount;
           }

           private double getamount()
           {
            //if you are returning, use get
            return amount;
           }

            private void setDescription(string description)
            {
                this.description = description;
            }

            private string getdescription()
            {
                return description;
            }

    }
}  