using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AI.JavascriptTools.Web.App_Start
{
    public class UtilitiesConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/utilities").Include("~/Scripts/utilities/*.js"));
        }
    }
}