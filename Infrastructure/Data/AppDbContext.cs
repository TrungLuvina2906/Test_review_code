public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<ProductStyle> ProductStyles { get; set; }
    public DbSet<OperationRate> OperationRates { get; set; }
    public DbSet<ProductionTicket> ProductionTickets { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<PayrollPeriod> PayrollPeriods { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<PayrollDetail> PayrollDetails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}