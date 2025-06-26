namespace StorageApi.DTOs;

public class ProductStatsDto
{
    public int TotalProducts { get; set; }
    public decimal TotalInventoryValue { get; set; }
    public decimal AveragePrice { get; set; }
}