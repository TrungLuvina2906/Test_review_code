public class EmployeeController : ControllerBase
{
    private readonly IRepository<Employee> _repository;
    public EmployeeController(IRepository<Employee> repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAll()
    {
        return Ok(await _repository.GetAllAsync());
    }
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] Employee employee)
    {
        await _repository.AddAsync(employee);
        return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetById(long id)
    {
        var employee = await _repository.GetByIdAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(long id, [FromBody] Employee employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }
        await _repository.UpdateAsync(employee);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        await _repository.DeleteAsync(id);
        return NoContent();
    }
}