﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcRouting;

namespace MvcWeb
{
    public class HomeController
    {
        public ActionResult Index()
        {
            return new StaticViewResult();
        }
    }
}