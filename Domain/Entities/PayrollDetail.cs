public class PayrollDetail : BaseEntity
{
    public long PayrollId { get; set; }
    public Payroll Payroll { get; set; } = default!;
    public DateOnly WorkDate { get; set; }
    public long ProductStyleId { get; set; }
    public long OperationId { get; set; }
    public decimal Qty { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Amount { get; set; }
    public long SourceTicketId { get; set; }
}