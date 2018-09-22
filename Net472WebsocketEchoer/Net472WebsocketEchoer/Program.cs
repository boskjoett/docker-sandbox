using System;
using System.Threading;

namespace Net472WebsocketEchoer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsocketServer websocketServer = new WebsocketServer();

            Console.WriteLine("Starting websocket listener at ws://+:80/test");

            websocketServer.Start("http://+:80/test/");

            // Prevent app from exiting
            new ManualResetEvent(false).WaitOne();
        }
    }
}
