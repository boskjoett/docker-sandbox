using System;
using System.Threading;

namespace NetCoreWebsocketEchoer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsocketServer websocketServer = new WebsocketServer();

            Console.WriteLine("Starting websocket listener at ws://+:8080/test");

            websocketServer.Start("http://+:8080/test/");

            // Prevent app from exiting
            new ManualResetEvent(false).WaitOne();
        }
    }
}
