public class Employee : BaseEntity
{
    public string EmployeeCode { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public DateOnly? DateOfBirth { get; set; }
    public DateOnly JoinDate { get; set; }
    public decimal BaseSalary { get; set; }
    public EmployeeStatus Status { get; set; }

    public long TeamId { get; set; }
    public Team Team { get; set; } = default!;

    public ICollection<ProductionTicket> ProductionTickets { get; set; } = new List<ProductionTicket>();
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}