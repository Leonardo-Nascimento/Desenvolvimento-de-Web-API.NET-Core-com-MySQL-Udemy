﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Models
{
    public class ReturnAllServices
    {
        public bool Result { get; set; }
        public string ErrorMessage { get; set; }
        public Object objRetornado { get; set; }
    }
}
