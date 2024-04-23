using Grpc.Core;
using GrpcTestServer;

namespace GrpcTestServer.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "You are " + request.Name
        });
    }

    public override Task<HelloRequest> SayHelloReverse(HelloReply reply, ServerCallContext context)
    {
        Task<HelloRequest> request = Task.FromResult(new HelloRequest
        {
            Name = "You are " + reply.Message
        });
        return request;
        }
    }
