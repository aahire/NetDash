﻿// Copyright (c) 2014, Insya Interaktif.
// All rights reserved.

using System.Web.Mvc;

namespace Insya.NetDash
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}