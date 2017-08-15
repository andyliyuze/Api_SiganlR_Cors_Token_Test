
using Microsoft.AspNet.SignalR;
using System;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace Atrribute.Authorize
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public class HubAuthorizeAttribute : AuthorizeAttribute
    {
        

        public override bool AuthorizeHubConnection(HubDescriptor hubDescriptor, IRequest request)
        {
            //var request = HttpContent.Current.Request;

            if (request.Cookies["token"] != null)
            {
                var token = request.Cookies["token"].Value;
                return true;

            }
            return false;
        }
    }
}