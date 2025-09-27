using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class PageLinkCategoryF
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Status { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int Version { get; set; }
        public string Tags { get; set; } = string.Empty;
        
    }
}