public class Attendance : BaseEntity
{
    public long EmployeeId { get; set; }
    public Employee Employee { get; set; } = default!;
    public DateOnly WorkDate { get; set; }
    public TimeSpan CheckInTime { get; set; }
    public TimeSpan CheckOutTime { get; set; }
    public decimal WorkDayValue { get; set; }
    public decimal OvertimeHours { get; set; }
    public LeaveType LeaveType { get; set; }
}