using System;
using System.Data.SqlClient;

namespace CalcServiceCaller
{
    internal class Database
    {
        private string connectionString;

        public Database (string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ReadTable1Messages(int maxCount)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand($"SELECT TOP {maxCount} Id, Timestamp, Message FROM Table_1", connection);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader[0];
                        DateTime timestamp = (DateTime)reader[1];
                        string message = (string)reader[2];

                        Console.WriteLine($"Id: {id}, Timestamp: {timestamp}, Message: {message}");
                    }
                }
            }
        }

        public void ReadTable2Messages()
        {
            using (var connection = new SqlConnection(connectionString))
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

        public void InsertTable1Message(DateTime timestamp, string message)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand($"INSERT INTO Table_1 (Timestamp, Message) VALUES (@value1, @value2)", connection);
                command.Parameters.AddWithValue("@value1", timestamp);
                command.Parameters.AddWithValue("@value2", message);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
