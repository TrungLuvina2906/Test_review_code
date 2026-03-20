public class Team : BaseEntity
{
    public string TeamCode { get; set; } = default!;
    public string TeamName { get; set; } = default!;
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}