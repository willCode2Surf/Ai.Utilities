using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AI.JavascriptTools.Web.Models;

namespace AI.JavascriptTools.Web.Controllers.Api
{
    public class BarChartController : ApiController
    {

       public HighchartsModel Get()
       {
           var rand = new Random();
           return new HighchartsModel()
                {
                    Title = "BarChart",
                    Categories = CreateCategories(10).ToList(),
                    Series = new List<HighchartsSeries>()
                        {
                            CreateSeries("Series 1", 10, rand),
                            CreateSeries("Series 2", 10, rand),
                        }
                };
        }

        private IEnumerable<string> CreateCategories(int length)
        {
            var cats = new List<string>();
            for (int i = 0; i < length; i++)
            {
                cats.Add("T" + i.ToString());
            }

            return cats;
        } 

        private HighchartsSeries CreateSeries(string name, int length, Random rand)
        {
            var data = new List<decimal>();
            for (int i = 0; i < length; i++)
            {
                data.Add(Convert.ToDecimal(rand.NextDouble()));
            }

            return new HighchartsSeries()
                {
                    name = name,
                    data = data
                };
        }
    }
}
