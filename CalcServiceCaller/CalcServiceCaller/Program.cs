using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CalcServiceCaller
{
    //
    // The Docker container running the Calculator web service must be named "calcapi".
    // No port specification is needed when two containers communicate via the bridge network.
    //
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            bool repeat = true;
            string connectionString = "Server=tcp:demodb,1433;Database=DockerDb;User Id=sa;Password=ZylincHello2015;";
            Console.WriteLine("Database connection string: " + connectionString);
            Database db = new Database(connectionString);

            Console.WriteLine("\nReading latest 10 rows from table_1 in database DockerDb in container called demodb");
            db.ReadTable1Messages(10);

            Console.WriteLine("\nReading from table_2 in database DockerDb in container called demodb");
            db.ReadTable2Messages();

            Console.WriteLine("\nCalling Calculator web service at URL http://calcapi/api/Calculator");

            while (repeat)
            {
                for (int n = 2; n < 100; n++)
                {
                    int result = GetSquare(n).Result;
                    if (result < 0)
                        break;

                    string message = $"The square of {n} = {result}";
                    Console.WriteLine(message);

                    db.InsertTable1Message(DateTime.Now, message);

                    Thread.Sleep(1000);
                }
            }
        }

        static async Task<int> GetSquare(int n)
        {
            int result = -1;
            HttpResponseMessage response = await client.GetAsync($"http://calcapi/api/Calculator/square/{n}");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                result = int.Parse(data);
            }

            return result;
        }
    }
}
