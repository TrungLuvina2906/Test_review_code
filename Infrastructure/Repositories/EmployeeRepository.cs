public class EmployeeRepository : IRepository<Employee>
{
    private readonly AppDbContext _context;
    public EmployeeRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Employee> GetByIdAsync(long id)
    {
        return await _context.Employees.FindAsync(id);
    }
    public async Task<List<Employee>> GetAllAsync()
    {
        return await _context.Employees.ToListAsync();
    }
    public async Task AddAsync(Employee entity)
    {
        await _context.Employees.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Employee entity)
    {
        _context.Employees.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(long id)
    {
        var employee = await GetByIdAsync(id);
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
    }
}