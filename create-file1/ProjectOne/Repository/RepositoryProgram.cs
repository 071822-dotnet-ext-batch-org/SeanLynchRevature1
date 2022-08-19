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
                connection.Close();
                return rList;
            }
        }

        public async Task<UpdatedRequestDTO> UpdateRequestAsync(Guid requestID, int Status)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:seaneosserver.database.windows.net,1433;Initial Catalog=sean_lynch_revature_server;Persist Security Info=False;User ID=SeaneoLynch;Password=Xeaneo2412$$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"Update Request SET Status = @status requestID = id", connection))
            {
                command.Parameters.AddWithValue("@status", Status);
                command.Parameters.AddWithValue("id", requestID);
                connection.Open();
                int Ret = await command.ExecuteNonQueryAsync();

                if (Ret == 1)
                {
                    connection.Close();
                    UpdatedRequestDTO urbi = await this.UpdatedRequestByIdAsync(requestID);
                    return urbi;
                }
                connection.Close();
                return null;
            }
        }

        public async Task<bool> TicketRequestAsync(Request ticketRequest)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:seaneosserver.database.windows.net,1433;Initial Catalog=sean_lynch_revature_server;Persist Security Info=False;User ID=SeaneoLynch;Password=Xeaneo2412$$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"INSERT INTO dbo.Request (RequestID, FK_EmployeeID, Details, Amount, Type) values (@RequestID, @FK_EmployeeID, @Details, @Amount, @Type)", connection))
            {
                command.Parameters.AddWithValue("@RequestID", ticketRequest.requestID);
                command.Parameters.AddWithValue("@FK_EmployeeID", ticketRequest.FK_EmployeeID);
                command.Parameters.AddWithValue("@Details", ticketRequest.Details);
                command.Parameters.AddWithValue("@Amount", ticketRequest.Amount);
                command.Parameters.AddWithValue("@Type", ticketRequest.Type);
                connection.Open();
                int Ret = await command.ExecuteNonQueryAsync();
                connection.Close();
                return Ret == 1;   
            }


        }

        private async Task<UpdatedRequestDTO> UpdatedRequestByIdAsync(Guid requestID)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:seaneosserver.database.windows.net,1433;Initial Catalog=sean_lynch_revature_server;Persist Security Info=False;User ID=SeaneoLynch;Password=Xeaneo2412$$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"Update Request SET requestID = id", connection))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                connection.Open();
                SqlDataReader? Ret = await command.ExecuteReaderAsync();

                if (Ret.Read())
                {
                    UpdatedRequestDTO r = new UpdatedRequestDTO(Ret.GetGuid(0), Ret.GetString(1), Ret.GetString(2), Ret.GetInt32(3));
                    connection.Close();
                    return r;
                }
                connection.Close();
                return null;
            }
        }
        public async Task<bool> IsManagerAsync(Guid employeeID)
        {
            SqlConnection connection = new SqlConnection("Server=tcp:seaneosserver.database.windows.net,1433;Initial Catalog=sean_lynch_revature_server;Persist Security Info=False;User ID=SeaneoLynch;Password=Xeaneo2412$$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT IsManager FROM Employees WHERE EmployeeID = @id", connection))
            {
                command.Parameters.AddWithValue("@id", employeeID);
                connection.Open();
                SqlDataReader? Ret = await command.ExecuteReaderAsync();
                if (Ret.Read())
                {
                    if (Ret.GetBoolean(0))
                    {
                        return true;
                    }
                }
                connection.Close();

                return false;
            }
        }
    }
}

        

    