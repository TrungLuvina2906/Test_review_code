public class Payroll : BaseEntity
{
    public long PayrollPeriodId { get; set; }
    public PayrollPeriod PayrollPeriod { get; set; } = default!;
    public long EmployeeId { get; set; }
    public Employee Employee { get; set; } = default!;
    public decimal ProductSalary { get; set; }
    public decimal TimeSalary { get; set; }
    public decimal OvertimeAmount { get; set; }
    public decimal AllowanceAmount { get; set; }
    public decimal BonusAmount { get; set; }
    public decimal PenaltyAmount { get; set; }
    public decimal DeductionAmount { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal NetAmount { get; set; }
    public ICollection<PayrollDetail> Details { get; set; } = new List<PayrollDetail>();
}