using System.ComponentModel.DataAnnotations;

namespace LoadTest.Data.Models
{
    public partial class VW_CapitalProfitReportF
    {
        public int Id { get; set; }
        public string ReportData { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public decimal Percentage { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Period { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int RecordCount { get; set; }
        
    }
}