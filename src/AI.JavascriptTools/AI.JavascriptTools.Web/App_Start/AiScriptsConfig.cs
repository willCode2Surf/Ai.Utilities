using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AI.JavascriptTools.Web
{
    public class AiScriptsConfig
    {

        public static void Register(BundleCollection bundles)
        {
            var bundleOrder = new BundleFileSetOrdering("AIBundleOrder");
            
            bundles.Add(new ScriptBundle("~/bundles/scripts/ai").Include(
                "~/Scripts/knockout-{version}.js",
                "~/scripts/knockoutBinder/binder.js",
                "~/Scripts/utilities/*.js",
                "~/Scripts/highcharts/highcharts.src.js",
                "~/Scripts/highcharts/exporting.js",
                "~/scripts/graphs/*.js",
                "~/scripts/ViewModels/*.js"
                ));


            bundleOrder.Files.Add("knockout-{version}.js");
            bundleOrder.Files.Add("highcharts*");
            bundleOrder.Files.Add("exporting*");
            bundleOrder.Files.Add("utilities.*");
            bundles.FileSetOrderList.Add(bundleOrder);
        }
    }
}