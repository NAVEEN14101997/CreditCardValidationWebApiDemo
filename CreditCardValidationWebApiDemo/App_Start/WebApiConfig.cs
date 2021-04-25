using BusinessLayer.Implementation;
using BusinessLayer.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace CreditCardValidationWebApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            var container = new UnityContainer();
            container.RegisterType<IDecrypt, Decrypt>();
            container.RegisterType<IEncrypt, Encrypt>();
             //this
            config.DependencyResolver = new UnityDependencyResolver(container);
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
