using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TennisKlubben.Data
{
    public class DatabaseHandler
    {
        string connString = "Server = localhost; Database = TennisClub; User Id = admin; Password = admin; MultipleActiveResultSets=True;";

        public DatabaseQueryResponse ExecuteNonQuery(SqlConnection connection, string query, params SqlParameter[] parameters)
        {
            DatabaseQueryResponse response = new DatabaseQueryResponse();
            response.TimeStamp = DateTime.Now;

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (SqlParameter parameter in parameters)
                        command.Parameters.Add(parameter);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                    response.Success = true;
                    response.Data = null;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Data = null;
                response.ResponseMessage = ex.Message;
                return response;
            }
        }

        public DatabaseQueryResponse InsertNewUser(string firstName, string lastName, string address, string telephone, DateTime birthDate)
        {
            string query = "INSERT INTO dbo.Members (first_name, last_name, address, telephone, birth_date) " +
                          "VALUES (@first_name, @last_name, @address, @telephone, @birth_date)";

            DatabaseQueryResponse queryResponse = ExecuteNonQuery(new SqlConnection(connString),
                                                                  query,
                                                                  new SqlParameter("@first_name", firstName),
                                                                  new SqlParameter("@last_name", lastName),
                                                                  new SqlParameter("@address", address),
                                                                  new SqlParameter("@telephone", telephone),
                                                                  new SqlParameter("@birth_date", birthDate));

            return queryResponse;
        }
    }
}