using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TicketsDTO
    {
        public TicketsDTO(Guid idEmployee, string details, decimal amount, int type)
        {
            this.idEmployee = idEmployee;
            Details = details;
            Amount = amount;
            Type = type;
        }

        public Guid idEmployee { get; set; }
        public string Details { get; set; }
        public decimal Amount { get; set; }
        public int Type { get; set; }
        
    }
}
