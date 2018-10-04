using System;
using System.Threading.Tasks;

using Grpc.Core;

using Calculator;

namespace GrpcServer 
{
    class CalculatorServicer : Calculate.CalculateBase 
    {
        public override Task<IntResponse> Add(IntRequest request, ServerCallContext context) 
        {
            int result = request.X + request.Y;
            return Task.FromResult(new IntResponse() { Result = result });
        }

        public override Task<IntResponse> Mul(IntRequest request, ServerCallContext context) 
        {
            int result = request.X * request.Y;
            return Task.FromResult(new IntResponse() { Result = result });
        }

        public override Task<IntResponse> Pow(IntRequest request, ServerCallContext context)
        {
            int result = (int)Math.Pow(request.X, request.Y);
            return Task.FromResult(new IntResponse() { Result = result });
        }
    }

    class Program {
        const int Port = 50051;

        public static void Main(string[] args)
        {
            Server server = new Server 
            {
                Services = { Calculate.BindService(new CalculatorServicer()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure)}
            };
            
            Console.WriteLine("Starting server...");
            server.Start();

            Console.WriteLine("Calculator server listiening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();
            
            Console.WriteLine("Server shutting down...");
            server.ShutdownAsync().Wait();

            Console.WriteLine("Server has been shutdown!\nExiting program!");
        }
    }
}
