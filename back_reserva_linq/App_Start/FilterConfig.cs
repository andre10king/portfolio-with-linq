﻿using System.Web;
using System.Web.Mvc;

namespace back_reserva_linq
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
