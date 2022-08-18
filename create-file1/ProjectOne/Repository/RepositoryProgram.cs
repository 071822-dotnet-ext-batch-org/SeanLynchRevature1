using Models;
using System.Data.SqlClient;

namespace Repository
{
    public class RepositoryProgram
    {
        public async Task<List<Request>> RequestsAsync(int type, Guid? id)
        {

            SqlConnection connection = new SqlConnection("Server=tcp:seaneosserver.database.windows.net,1433;Initial Catalog=sean_lynch_revature_server;Persist Security Info=False;User ID=SeaneoLynch;Password=Xeaneo2412$$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Request WHERE type = @type and requestID = @id", connection))
            {
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader? Ret = await command.ExecuteReaderAsync();
                List<Request> rList = new List<Request>();
                while (Ret.Read())
                {
                    Request r = new Request((Guid)Ret[0], (Guid)Ret[1], Ret.GetString(2), Ret.GetDecimal(3), Ret.GetInt32(4));
                    rList.Add(r);
                }
                return rList;
            }
        }

    }
}

    