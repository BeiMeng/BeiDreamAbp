using System.Web.Mvc;

namespace BeiDream.Mpa.Areas.MicroSite
{
    public class MicroSiteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MicroSite";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MicroSite_default",
                "MicroSite/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}