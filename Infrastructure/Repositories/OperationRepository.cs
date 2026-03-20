public class OperationRepository : IRepository<Operation>
{
    private readonly AppDbContext _context;
    public OperationRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Operation> GetByIdAsync(long id)
    {
        return await _context.Operations.FindAsync(id);
    }
    public async Task<List<Operation>> GetAllAsync()
    {
        return await _context.Operations.ToListAsync();
    }
    public async Task AddAsync(Operation entity)
    {
        await _context.Operations.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Operation entity)
    {
        _context.Operations.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(long id)
    {
        var operation = await GetByIdAsync(id);
        _context.Operations.Remove(operation);
        await _context.SaveChangesAsync();
    }
}