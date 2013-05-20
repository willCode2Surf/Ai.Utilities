using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AI.JavascriptTools.Web.App_Start
{
    public class HighchartsConfig
    {

        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/highcharts").Include("~/Scripts/highcharts/highcharts.src.js"));
            bundles.Add(new ScriptBundle("~/bundles/scripts/exporting").Include("~/Scripts/highcharts/exporting.js"));
            bundles.Add(new ScriptBundle("~/bundles/scripts/graphs").Include("~/scripts/graphs/*.js"));

        }
    }
}