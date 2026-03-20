public class ProductStyle : BaseEntity
{
    public string StyleCode { get; set; } = default!;
    public string StyleName { get; set; } = default!;
    public string CustomerName { get; set; } = default!;
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
}