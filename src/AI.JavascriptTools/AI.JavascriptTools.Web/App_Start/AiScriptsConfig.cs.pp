using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace $rootnamespace$
{
    public class AiScriptsConfig
    {

        public static void Register(BundleCollection bundles)
        {
             var bundleOrder = new BundleFileSetOrdering("AIBundleOrder");

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/scripts/ai").Include(
                "~/scripts/knockoutBinder/binder.js",
                "~/Scripts/utilities/*.js",
                "~/scripts/graphs/*.js",
                "~/scripts/ViewModels/*.js"
                ));


            bundleOrder.Files.Add("knockout-{version}.js");
            bundleOrder.Files.Add("highcharts*");
            bundleOrder.Files.Add("exporting*");
            bundleOrder.Files.Add("namespace*");
            bundleOrder.Files.Add("utilities.*");
            bundleOrder.Files.Add("graphs.*");

            BundleTable.Bundles.FileSetOrderList.Add(bundleOrder);
        }
    }
}