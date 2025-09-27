using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class SellingPaymentListD
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime Date { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string PaymentTerms { get; set; } = string.Empty;
        public string ShippingMethod { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        public bool IsPaid { get; set; }
        public string Currency { get; set; } = string.Empty;
        
    }
}