using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace learning_site.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css/styles.css")
                            .Include(
                                "~/html-template/assets/css/bootstrap.min.css",
                                "~/html-template/style.css",
                                "~/html-template/assets/css/slick.css",
                                "~/html-template/assets/css/theme-color/royal-blue-theme.css"

                            ));

            bundles.Add(new ScriptBundle("~/bundles/js/scripts.js")
                            .Include(
                                "~/html-template/assets/js/bootstrap.min.js",
                                "~/html-template/assets/js/slick.min.js",
                                "~/html-template/assets/js/app.js",
                                "~/html-template/assets/js/custom.js"
                            ));
        }
    }


    //public static void RegisterBundles(BundleCollection bundles)
    //    {
    //        bundles.Add(new Bundle("~/bundles/css/styles.css")
    //            .Include(
    //                "~/html-template/style.css",
    //                "https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css",
    //                "https://fonts.googleapis.com/css?family=Open+Sans:300,400,400i,600,700,800",
    //                "https://fonts.googleapis.com/css?family=Lato",
    //                "~/html-template/assets/css/*.css",
    //                "~/html-template/assets/css/theme-color/*.css"
    //            ));
    //        BundleTable.EnableOptimizations = true;
    //    }
    //}
}