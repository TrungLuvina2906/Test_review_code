public class OperationRate : BaseEntity
{
    public long ProductStyleId { get; set; }
    public ProductStyle ProductStyle { get; set; } = default!;

    public long OperationId { get; set; }
    public Operation Operation { get; set; } = default!;

    public decimal UnitPrice { get; set; }
    public DateOnly EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public bool IsActive { get; set; }
    public string? Note { get; set; }
}