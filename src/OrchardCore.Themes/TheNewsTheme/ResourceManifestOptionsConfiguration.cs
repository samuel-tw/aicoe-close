using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheNewsTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineScript("TheBlogTheme-bootstrap-bundle")
                .SetCdn("https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js", "https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.js")
                .SetCdnIntegrity("sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p", "sha384-8fq7CZc5BnER+jVlJI2Jafpbn4A9320TKhNJfYP33nneHep7sUg/OD30x7fK09pS")
                .SetVersion("5.1.3");

            _manifest
                .DefineStyle("bootstrap-min")
                .SetUrl("~/TheNewsTheme/assets/css/bootstrap.min.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("animate-min")
                .SetUrl("~/TheNewsTheme/assets/css/animate.min.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("flaticon")
                .SetUrl("~/TheNewsTheme/assets/css/flaticon.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("fontawesome-min")
                .SetUrl("~/TheNewsTheme/assets/css/fontawesome.min.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("meanmenu")
                .SetUrl("~/TheNewsTheme/assets/css/meanmenu.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("magnific-popup-min")
                .SetUrl("~/TheNewsTheme/assets/css/magnific-popup.min.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("owl-carousel-min")
                .SetUrl("~/TheNewsTheme/assets/css/owl.carousel.min.css")
                .SetVersion("1.0.0");
            _manifest
                .DefineStyle("style")
                .SetUrl("~/TheNewsTheme/assets/css/style.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("responsive")
                .SetUrl("~/TheNewsTheme/assets/css/responsive.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("bootstrap-icons")
                .SetUrl("~/TheNewsTheme/assets/icons-1.10.3/font/bootstrap-icons.css")
                .SetVersion("1.0.0");
            _manifest
                .DefineStyle("flag-icons")
                .SetUrl("~/TheNewsTheme/assets/flag-icons/css/flag-icons.min.css")
                .SetVersion("1.0.0");
            _manifest
                .DefineStyle("aicoe-style")
                .SetUrl("~/TheNewsTheme/assets/css/aicoeStyle.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("aicoe-scss")
                .SetUrl("~/TheNewsTheme/assets/css/aicoe-scss.scss")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("jquery-min")
                .SetUrl("~/TheNewsTheme/assets/js/jquery.min.js")
                .SetVersion("1.0.0");

             _manifest
                .DefineScript("bootstrap-min")
                .SetUrl("~/TheNewsTheme/assets/js/bootstrap.min.js")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("jquery-meanmenu")
                .SetUrl("~/TheNewsTheme/assets/js/jquery.meanmenu.js")
                .SetVersion("1.0.0");

            _manifest
               .DefineScript("jquery-appear-min")
               .SetUrl("~/TheNewsTheme/assets/js/jquery.appear.min.js")
               .SetVersion("1.0.0");

            _manifest
                .DefineScript("jquery-waypoints-min")
                .SetUrl("~/TheNewsTheme/assets/js/jquery.waypoints.min.js")
                .SetVersion("1.0.0");

            _manifest
               .DefineScript("jquery-counterup-min")
               .SetUrl("~/TheNewsTheme/assets/js/jquery.counterup.min.js")
               .SetVersion("1.0.0");

            _manifest
               .DefineScript("jquery-magnific-popup-min")
               .SetUrl("~/TheNewsTheme/assets/js/jquery.magnific-popup.min.js")
               .SetVersion("1.0.0");

            _manifest
                .DefineScript("isotope-pkgd-min")
                .SetUrl("~/TheNewsTheme/assets/js/isotope.pkgd.min.js")
                .SetVersion("1.0.0");

            _manifest
               .DefineScript("owl-carousel-min")
               .SetUrl("~/TheNewsTheme/assets/js/owl.carousel.min.js")
               .SetVersion("1.0.0");

            _manifest
                .DefineScript("wow-min")
                .SetUrl("~/TheNewsTheme/assets/js/wow.min.js")
                .SetVersion("1.0.0");

            _manifest
               .DefineScript("main")
               .SetUrl("~/TheNewsTheme/assets/js/main.js")
               .SetVersion("1.0.0");

            _manifest
               .DefineScript("font-size-selector")
               .SetUrl("~/TheNewsTheme/assets/js/fontsize.js")
               .SetVersion("1.0.0");


            _manifest
               .DefineScript("aicoe")
               .SetUrl("~/TheNewsTheme/assets/js/aicoe.js")
               .SetVersion("1.0.0");

            _manifest
               .DefineScript("spotlight")
               .SetUrl("~/TheNewsTheme/assets/js/spotlight.bundle.js")
               .SetVersion("1.0.0");

            _manifest
               .DefineScript("jstorage")
               .SetUrl("~/TheNewsTheme/assets/js/jstorage.js")
               .SetVersion("1.0.0");
            _manifest
               .DefineScript("jfontsize")
               .SetUrl("~/TheNewsTheme/assets/js/jquery.jfontsize-2.0.js")
               .SetVersion("1.0.0");

        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}


