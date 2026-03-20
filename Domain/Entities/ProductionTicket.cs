public class ProductionTicket : BaseEntity
{
    public DateOnly WorkDate { get; set; }
    public long EmployeeId { get; set; }
    public Employee Employee { get; set; } = default!;
    public long ProductStyleId { get; set; }
    public ProductStyle ProductStyle { get; set; } = default!;
    public long OperationId { get; set; }
    public Operation Operation { get; set; } = default!;
    public decimal GoodQty { get; set; }
    public decimal DefectQty { get; set; }
    public string? ShiftCode { get; set; }
    public string? Note { get; set; }
}