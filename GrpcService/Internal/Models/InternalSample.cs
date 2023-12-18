namespace GrpcService.Internal.Models;

public class InternalSample
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public IEnumerable<string> ItemList { get; set; }
}