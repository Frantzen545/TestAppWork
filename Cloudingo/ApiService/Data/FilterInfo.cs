using System;
namespace Cloudingo.Data
{
    public class FilterInfo
    {
        public bool Enabled { get; set; }
        public Guid FilterId { get; set; }
        public string FilterName { get; set; }
        public string FilterStatus { get; set; }
        public string FilterType { get; set; }
        public int GroupCount { get; set; }
        public int GroupSet { get; set; }
        public bool IsDedupe { get; set; }
        public int MatchCount { get; set; }
        public int ProgressPercentage { get; set; }
        public int ReportId { get; set; }
        public int TotalGroupSet { get; set; }
    }
}
