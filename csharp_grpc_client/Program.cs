using System;

using Grpc.Core;

using Calculator;

namespace csharp_grpc_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# client to server call");

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
