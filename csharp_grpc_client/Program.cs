using System;

using Grpc.Core;

using Calculator;
using GrpcServer;

namespace csharp_grpc_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# client to server call");

            if(args.Length == 0)
            {
                Console.WriteLine("Provide (c)lient or (s)erver when running this console application.");
                Environment.Exit(0);
            }
            
            if(args[0].ToLower() == "c" || args[0].ToLower() == "client")
                RunClient();
            else if(args[0].ToLower() == "s" || args[0].ToLower() == "server")
                MyGrpcServer.RunServer();
        }

        static void RunClient()
        {
            IntRequest request = new IntRequest { X = 3, Y = 4};
            Channel channel = new Channel("localhost", 50051, ChannelCredentials.Insecure);

            Calculate.CalculateClient client = new Calculate.CalculateClient(channel);
            IntResponse a = client.Add(request);
            IntResponse m = client.Mul(request);
            IntResponse p = client.Pow(request);

            channel.ShutdownAsync().Wait();

            Console.WriteLine("Server response.");
            Console.WriteLine("3+4= {0}", a.Result);
            Console.WriteLine("3*4= {0}", m.Result);
            Console.WriteLine("3^4= {0}", p.Result);
        }
    }
}
