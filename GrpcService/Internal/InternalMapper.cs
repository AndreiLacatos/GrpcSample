using GrpcService.Internal.Models;
using GrpcService.Services.Models;
using Riok.Mapperly.Abstractions;

namespace GrpcService.Internal;

[Mapper]
public static partial class InternalMapper
{
    public static partial SampleModel Map(InternalSample source);

    public static partial InternalSample Map(SampleModel source);

    private static string MapSpecial(Guid source) => $"internal/{source}";

    private static Guid MapSpecial(string source) => Guid.Parse(source.Split('/')[^1]);
}