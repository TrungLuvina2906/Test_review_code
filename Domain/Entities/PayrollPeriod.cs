public class PayrollPeriod : BaseEntity
{
    public string Code { get; set; } = default!;
    public DateOnly DateFrom { get; set; }
    public DateOnly DateTo { get; set; }
    public PayrollStatus Status { get; set; }
}