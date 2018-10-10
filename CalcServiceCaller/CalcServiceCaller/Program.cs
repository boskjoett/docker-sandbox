using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalcServiceCaller
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            for (int n = 2; n < 10; n++)
            {
                int result = GetSquare(n).Result;
                Console.WriteLine($"The square of {n} = {result}");
            }

            Console.WriteLine("Press any key to exit");
        }

        static async Task<int> GetSquare(int n)
        {
            int result = -1;
            HttpResponseMessage response = await client.GetAsync($"http://localhost:5000/api/Calculator/square/{n}");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                result = int.Parse(data);
            }

            return result;
        }
    }
}
