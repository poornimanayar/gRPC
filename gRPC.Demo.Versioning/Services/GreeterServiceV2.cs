using Greet.V2;
using Grpc.Core;
using gRPC.Basic;

namespace gRPC.Basic.Services;

public class GreeterServiceV2 : Greeter.GreeterBase
{
    private readonly ILogger<GreeterServiceV2> _logger;

    public GreeterServiceV2(ILogger<GreeterServiceV2> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine(request.Name);
        return Task.FromResult(new HelloReply
        {
            Message = $"Hello {request.Name}! {request.Notes}"
        });
    }
}