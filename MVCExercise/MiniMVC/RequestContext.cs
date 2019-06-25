﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MiniMVC
{
    public class RequestContext
    {
        public virtual HttpContextBase HttpContext { get; set; }

        public virtual RouteData RouteData { get; set; }
    }
}
