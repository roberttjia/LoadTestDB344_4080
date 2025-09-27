using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class ServiceDevice
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
        public decimal ServiceFee { get; set; }
        public decimal LaborCost { get; set; }
        public decimal MaterialCost { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public string Technician { get; set; } = string.Empty;
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        public string WarrantyPeriod { get; set; } = string.Empty;
        public bool IsUnderWarranty { get; set; }
        
    }
}