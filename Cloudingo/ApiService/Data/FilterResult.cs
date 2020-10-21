using System;
namespace Cloudingo.Data
{
    public class FilterResult
    {
        public FilterInfo[] Filters { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }
    }
}
