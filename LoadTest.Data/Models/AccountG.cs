using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class AccountG
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public string AccountType { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string Notes { get; set; } = string.Empty;
        
    }
}