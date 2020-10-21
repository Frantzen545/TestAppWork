using System;
using System.Diagnostics;
using Cloudingo.Data;
using Newtonsoft.Json;

namespace ApiService.Service
{
    public class CloudingoService
    {
        const string PATH = "/Users/michaelfrantzen/Downloads/GetFilters.json";

        public FilterResult GetFilters()
        {
            FilterResult filterResult = null;
            try
            {
                string text = System.IO.File.ReadAllText(PATH);
                filterResult = JsonConvert.DeserializeObject<FilterResult>(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Debugger.Break();
            }
            return filterResult;
        }
    }
}
