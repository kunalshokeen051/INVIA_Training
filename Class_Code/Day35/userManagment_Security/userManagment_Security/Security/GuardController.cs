﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace userManagment_Security.Security
{
    public class GuardController : ActionFilterAttribute, IAuthenticationFilter
    {
        void IAuthenticationFilter.OnAuthentication(AuthenticationContext filterContext)
        {
            //This function will be executed before the controller loads into memory
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["Usr"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }


        }

        void IAuthenticationFilter.OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }
    }
}