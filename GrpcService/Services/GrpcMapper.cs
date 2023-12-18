using Google.Protobuf.Collections;
using GrpcService.Services.Models;
using Riok.Mapperly.Abstractions;

namespace GrpcService.Services;

[Mapper]
public static partial class GrpcMapper
{
    [MapperIgnoreSource(nameof(SampleModel.Id))]
    [MapProperty(nameof(SampleModel.ItemList), nameof(SampleResponse.Items))]
    public static partial SampleResponse MapGrpc(SampleModel source);

    private static string MapSpecial(Guid source) => $"hello/{source}";

    private static RepeatedField<string> MapSpecialArray(IEnumerable<Guid> source) => new()
    {
        source.Select(MapSpecial),
    };
}