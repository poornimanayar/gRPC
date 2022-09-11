using Grpc.Core;
using gRPC.Basic;

namespace gRPC.Basic.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context">Contains the context of the call - headers, authn information</param>
    /// <returns></returns>
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine(request.Name);
        Console.WriteLine($"Peer - {context.Peer} - Host {context.Host}");
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}