using System.ComponentModel.DataAnnotations;

namespace StorageApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Category { get; set; } = null!;

        [Required]
        public string Shelf { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Range(0, 100000)]
        public int Price { get; set; }

        [Range(0, 100000)]
        public int Count { get; set; }
    }

}
