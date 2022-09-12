
using gRPC.Basic;
using Grpc.Net.Client;

//gRPC channel - represents a connection to the remote server. 
//Very expensive operation to create a channel, so must be reused.
var channel = GrpcChannel.ForAddress("https://localhost:7211");
var client = new Greeter.GreeterClient(channel);

var response = client.SayHello(new HelloRequest() { Name = "client"});

Console.WriteLine($"Message from server - {response.Message}");

Console.ReadLine();

