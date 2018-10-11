using System;
using System.Data.SqlClient;

namespace CalcServiceCaller
{
    internal class Database
    {
        public void ReadMessages()
        {
            using (var connection = new SqlConnection("Server=tcp:demodb,1433;Initial Catalog=DockerDb;Persist Security Info=True;"))
            {
                var command = new SqlCommand("SELECT Message1, Message2 FROM Table_2", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Message1: {reader[0]}, Message2: {reader[1]}");
                    }
                }
            }
        }
    }
}
