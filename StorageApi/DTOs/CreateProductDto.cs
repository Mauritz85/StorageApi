using System.ComponentModel.DataAnnotations;

namespace StorageApi.Dtos;

public class CreateProductDto
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Range(1, int.MaxValue, ErrorMessage = "Pris måste vara minst 1.")]
    public int Price { get; set; }

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = null!;

    [Required]
    [StringLength(10)]
    public string Shelf { get; set; } = null!;

    [Range(0, int.MaxValue, ErrorMessage = "Antal får inte vara negativt.")]
    public int Count { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = string.Empty!;
}
