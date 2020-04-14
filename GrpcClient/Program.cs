using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {           
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);
            Console.WriteLine("Name: ");
            var input = Console.ReadLine();
            var clientRequested = new CustomerLookupModel { Name = input.ToString() };
            var customer = await customerClient.GetCustomerInfoAsync(clientRequested);
        }
    }
}
