
using DotNetNuke.Web.Api;
using System.Web.Http;

namespace Dnn.Modules.DnnSpaModule1.Services
{

    /// <summary>
    /// The ServiceRouteMapper tells the DNN Web API Framework what routes this module uses
    /// </summary>
    public class ServiceRouteMapper : IServiceRouteMapper
    {
        /// <summary>
        /// RegisterRoutes is used to register the module's routes
        /// </summary>
        /// <param name="mapRouteManager"></param>
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                moduleFolderName: "DnnSpaModule1",
                routeName: "default",
                url: "{controller}/{itemId}",
                defaults: new { itemId = RouteParameter.Optional },
                namespaces: new[] { "Dnn.Modules.DnnSpaModule1.Services" });
        }
    }

}