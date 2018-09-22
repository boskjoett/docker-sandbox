using System;
using System.Threading;

namespace DockerTestAppNET472
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Docker console test app started. x64 .NET 4.7.2");

            string envValue = Environment.GetEnvironmentVariable("HOSTNAME");
            Console.WriteLine("Value of environment variable HOSTNAME = " + envValue);

            envValue = Environment.GetEnvironmentVariable("MY_ENV_VAR");
            Console.WriteLine("Value of environment variable MY_ENV_VAR = " + envValue);

            int i = 1;

            while (true)
            {
                Console.WriteLine($"Log message {i}");
                Thread.Sleep(2000);
                i++;
            }
        }
    }
}
