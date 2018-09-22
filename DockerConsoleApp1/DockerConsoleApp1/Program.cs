using System;

namespace DockerConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square calculator is running");

            while (true)
            {
                Console.Write("\nEnter number: ");
                string input = Console.ReadLine();
                int n = int.Parse(input);
                Console.WriteLine($"Square of {n} =  {n * n}");

                if (n == 0)
                    break;
            }
        }
    }
}
