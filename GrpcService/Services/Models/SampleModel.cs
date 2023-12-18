namespace GrpcService.Services.Models;

public class SampleModel
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public IEnumerable<Guid> ItemList { get; set; }
}