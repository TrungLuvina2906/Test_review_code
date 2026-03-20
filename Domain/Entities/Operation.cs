public class Operation : BaseEntity
{
    public string OperationCode { get; set; } = default!;
    public string OperationName { get; set; } = default!;
    public string OperationGroup { get; set; } = default!;
    public string Unit { get; set; } = default!;
}