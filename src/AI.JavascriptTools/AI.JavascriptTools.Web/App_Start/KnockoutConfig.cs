using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AI.JavascriptTools.Web.App_Start
{
    public class KnockoutConfig
    {

        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/knockout").Include("~/Scripts/knockout-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/scripts/binder").Include("~/scripts/knockoutBinder/binder.js"));
        }
    }
}