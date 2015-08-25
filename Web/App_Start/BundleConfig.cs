// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Web
{
    using System.Web;
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/styles").Include(
                "~/content/css/bootstrap.css",
                "~/content/css/superfish.css",
                "~/content/css/custom.css",
                "~/content/fontello/css/fontello.css"));

            bundles.Add(new ScriptBundle("~/scripts/jquery").Include("~/content/js/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/scripts/angularjs").Include(
                "~/scripts/vendor/angular.js",
                "~/scripts/vendor/resource.js"));

            bundles.Add(new ScriptBundle("~/scripts/app").Include(
                "~/scripts/vendor/angular-ui-router.js",
                "~/scripts/filters.js",
                "~/scripts/services.js",
                "~/scripts/directives.js",
                "~/scripts/controllers.js",
                "~/scripts/app.js"));

            bundles.Add(new ScriptBundle("~/scripts/customjs").Include(
                "~/content/js/boostrap.js",
                "~/content/js/superfish.js",
                "~/content/js/retina.js",
                "~/content/js/validate.js",
                "~/content/js/jquery.placeholder.js",
                "~/content/js/functions.js",
                "~/content/js/classie.js",
                "~/content/js/uisearch.js"));
        }
    }
}