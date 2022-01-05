using System.Web.Mvc;

namespace DeltaCore.Areas.DeltaCoreProduct
{
    public class DeltaCoreProductAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DeltaCoreProduct";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DeltaCoreProduct_default",
                "DeltaCoreProduct/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}