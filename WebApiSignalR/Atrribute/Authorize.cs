using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSignalR.Atrribute
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public class HubAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool UserAuthorized(System.Security.Principal.IPrincipal user)
        {

            var request = HttpContext.Current.Request;
            if (request.Cookies["token"] !=null)
            {
                var token = request.Cookies["token"].Value;
                return true;

            }
            return false;
        }

    }
}