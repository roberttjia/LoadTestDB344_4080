using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class SellingExpenseF
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Vendor { get; set; } = string.Empty;
        public string InvoiceNumber { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public bool IsRecurring { get; set; }
        public string ApprovalStatus { get; set; } = string.Empty;
        
    }
}