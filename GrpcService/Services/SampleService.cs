using Grpc.Core;
using GrpcService.Services.Models;

namespace GrpcService.Services;

public class SampleService : Sample.SampleBase
{
    public override Task<SampleResponse> SampleCall(SampleRequest request, ServerCallContext context)
    {
        var data = new SampleModel
        {
            Id = 1,
            Message = "Hello",
            ItemList = new[]
            {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
            },
        };
        var mapped = GrpcMapper.MapGrpc(data);
        return Task.FromResult(mapped);
    }
}