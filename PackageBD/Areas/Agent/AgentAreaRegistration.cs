using System.Web.Mvc;

namespace PackageBD.Areas.Agent
{
    public class AgentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Agent";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Agent_default",
            //    "Agent/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);

            context.MapRoute(
                "Agent_default",
                "Agent/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "PackageBD.Areas.Agent.Controllers" }
            );
        }
    }
}