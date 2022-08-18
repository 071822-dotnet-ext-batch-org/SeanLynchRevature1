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
    }

}