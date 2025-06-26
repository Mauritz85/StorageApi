namespace StorageApi.Dtos;

public class ProductDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Count { get; set; }

    public decimal InventoryValue => Price * Count;
}
