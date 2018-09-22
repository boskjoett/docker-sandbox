using System;
using System.Threading;

namespace DockerConsoleAppLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 10000)
            {
                Console.WriteLine($"Log message {i} from Docker Console App");
                Thread.Sleep(2000);
                i++;
            }
        }
    }
}
