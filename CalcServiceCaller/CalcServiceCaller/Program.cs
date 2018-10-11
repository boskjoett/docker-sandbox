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

            Console.WriteLine("Reading from database DockerDb in container called demodb");
            Database db = new Database();
            db.ReadMessages();

            Console.WriteLine("Calling Calculator web service at URL http://calcapi/api/Calculator");

            while (repeat)
            {
                for (int n = 2; n < 100; n++)
                {
                    int result = GetSquare(n).Result;
                    if (result < 0)
                        break;

                    Console.WriteLine($"The square of {n} = {result}");

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
