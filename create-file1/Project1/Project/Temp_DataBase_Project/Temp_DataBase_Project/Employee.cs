using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseSystem
{
    internal class Employee
    {
        Reimbursement reimbursement;
        List<Reimbursement> previoussubmission;
        string description;
        public Employee()
        {
            reimbursement = null;
            previoussubmission = new List<Reimbursement>();
            description = "";

        }

        public Employee( Reimbursement reimbursement, List<Reimbursement> previoussubmission, string description)
        {
            this.reimbursement = reimbursement;
            this.previoussubmission = previoussubmission;
           this.description = description;
        }

        public Reimbursement GetReimbursement()
        {
            return reimbursement;

        }
        public void setReimbursement(Reimbursement reimbursement)
        {
            this.reimbursement = reimbursement;
        }
    }
}  