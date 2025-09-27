using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ProductCatalogE
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsActive { get; set; }
        public decimal Weight { get; set; }
        public string Dimensions { get; set; } = string.Empty;
        
    }
}