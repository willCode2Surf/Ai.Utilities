using System.Collections.Generic;

namespace AI.JavascriptTools.Web.Models
{
    public class HighchartsModel
    {
        public string Title { get; set; }
        public List<string> Categories { get; set; }
        public List<HighchartsSeries> Series { get; set; } 
    }
}