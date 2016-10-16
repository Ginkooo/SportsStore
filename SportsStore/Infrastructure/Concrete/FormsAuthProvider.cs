using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.WebUI.Infrastructure.Abstract;
using System.Web.Security;

namespace SportsStore.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool authenticated = FormsAuthentication.Authenticate(username, password);
            if (authenticated)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return authenticated;
        }
    }
}