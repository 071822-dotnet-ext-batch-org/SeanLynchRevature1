using Models;
using Repository;

namespace Business
{
    public class BusinessProgram
    {

        private readonly RepositoryProgram _Repository;

        public BusinessProgram()
        {
            this._Repository = new RepositoryProgram();
        }

        public async Task<List<Request>> RequestsAsync(int type, Guid? id)
        {
            List<Request> list = await this._Repository.RequestsAsync(type, id);
            return list;
        }

        public async Task<UpdatedRequestDTO> UpdateRequestAsync(ApprovalDTO approval)
        {
            if (await this._Repository.IsManagerAsync(approval.EmployeeID))
            {
                UpdatedRequestDTO approvedRequest = await this._Repository.UpdateRequestAsync(approval.EmployeeID, approval.Status);
                return approvedRequest;

            }
            else return null;
        }
        //                output (? makes the function return nullible) input
        //type of object, name
        public async Task<Request?> TicketAsync(TicketsDTO Ticketobject)
        {//we want the ticket object to be the same as the APIController
            Request ticketRequest = new Request(Guid.NewGuid(), Ticketobject.idEmployee, Ticketobject.Details, Ticketobject.Amount, Ticketobject.Type);
            //Guid.NewGuid() becomes the new requestID

            if (await this._Repository.TicketRequestAsync(ticketRequest))
            {
                return ticketRequest;
            }
            else return null;
        }
        public async Task<EmployeesDTO> EmployeesAsync(EmployeesDTO newGuy)
        {
            EmployeesDTO NewAccount = await this._Repository.NewGuyAsync(newGuy);
            return NewAccount;
        }

        public async Task<LoginDTO> LoginAsync(string emailGrab, int passwordSet)
        {
            LoginDTO EandPRequest = await this._Repository.LoginAsync(emailGrab, passwordSet);
            return EandPRequest;
        }
    }
}