using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Managers
    {
        private Reimbursement reimbursementTicket;
        
        private bool ticketApproval;

        private bool processing;

        public Managers()
        {
            reimbursementTicket = null;
            ticketApproval = false;
            processing = false;
        }

        public Managers(Reimbursement reimbursementTicket,bool ticketApproval, bool processing)
        {
            this.reimbursementTicket = reimbursementTicket;
            this.ticketApproval = ticketApproval;
            this.processing = processing;
        }

        public void setReimbursementTicket(Reimbursement reimbursementTicket)
        {
            this.reimbursementTicket = reimbursementTicket;

        }

        public Reimbursement getReimbursement()
        {
            return reimbursementTicket;
        }

        public void setApproval(bool ticketApproval)
        {
            this.ticketApproval = ticketApproval;
        }

        public Reimbursement getticketApproval()
        {
            return ticketApproval;
        }

        public void setProcessing(bool processing)
        {
            this.processing = processing;
        }

        public Reimbursement getProcessing()
        {
            return processing;
        }
    }
} 