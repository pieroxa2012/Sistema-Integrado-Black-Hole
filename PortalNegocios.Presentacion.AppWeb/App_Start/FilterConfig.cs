﻿using System.Web;
using System.Web.Mvc;

namespace PortalNegocios.Presentacion.AppWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
