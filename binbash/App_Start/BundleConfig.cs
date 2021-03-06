﻿using System.Web;
using System.Web.Optimization;

namespace binbash {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/bower_components/bootstrap-material-design/dist/js/material.js",
                      "~/bower_components/bootstrap-material-design/dist/js/ripples.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/bootstrap.css",
                      "~/bower_components/bootstrap-material-design/dist/css/material.css",
                      "~/bower_components/bootstrap-material-design/dist/css/ripples.css",
                      "~/bower_components/material-design-color-palette/css/material-design-color-palette.css",
                      "~/bower_components/font-awesome/css/font-awesome.css",
                      "~/Content/Styles/site.css"));
        }
    }
}
