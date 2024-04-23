using System.Threading.Channels;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
namespace GrpcTestClient;

internal class Program
{
	static async Task Main(string[] args)
	{
		GrpcChannel channel = GrpcChannel.ForAddress("http://127.0.0.1:8000");
		Greeter.GreeterClient client = new Greeter.GreeterClient(channel);
		HelloReply reply = new HelloReply() { Message = "Helloooo Negaaa" };
		HelloRequest request = await client.SayHelloReverseAsync(reply);

		Console.WriteLine(request.Name);
	}
}