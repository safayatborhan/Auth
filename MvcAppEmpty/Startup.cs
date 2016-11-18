using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(MvcAppEmpty.Startup))]

namespace MvcAppEmpty
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            GlobalFilters.Filters.Add(new AuthorizeAttribute());    //This should be added at first. It makes all the controllers Authorized. If there is no anonymous call.       

            //If the page is unauthorized then we will redirect to login page. This is the code
            CookieAuthenticationOptions options = new CookieAuthenticationOptions();
            options.AuthenticationType = "ApplicatinCookie";
            options.LoginPath = new PathString("/Auth/Login");
            app.UseCookieAuthentication(options);
        }
    }
}
