﻿using eUseControl.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using TW.App_Start;

namespace TW
{
     public class Global : HttpApplication
     {
          void Application_Start(object sender, EventArgs e)
          {
               // Code that runs on application startup
               AreaRegistration.RegisterAllAreas();
               RouteConfig.RegisterRoutes(RouteTable.Routes);

               BundleConfig.RegisterBundles(BundleTable.Bundles);
          }
     }
}