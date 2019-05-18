using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PProject.App_Start
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeRoleAttribute(params object[] roles)
        {
            if (Roles.Any(r => r.GetType().BaseType != typeof(Enum)))
            {
                throw new ArgumentException("Provided role should be of Enum type!");
            }

            this.Roles = string.Join(",", roles.Select(r => Enum.GetName(r.GetType(), r)));

        }
    }
}