using InventoryERP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace InventoryERP.Core
{
    public static class HttpContextHelper
    {
        public static bool IsAuthenticated
        {
            get { return HttpContext.Current.User.Identity.IsAuthenticated; }
        }

        public static bool IsMember
        {
            get { return IsAuthenticated && HttpContext.Current.User.IsInRole("Member"); }
        }

        public static bool IsAdmin
        {
            get { return IsAuthenticated && HttpContext.Current.User.IsInRole("Admin"); }
        }
        
        public static UserPrincipal Current
        {
            get
            {
                Check.Argument.Null(HttpContext.Current, "HttpContext.Current", "Currently no user attached with this session.");

                return HttpContext.Current.User as UserPrincipal;
            }
        }
    }
}
