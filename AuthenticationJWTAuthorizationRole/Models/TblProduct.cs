﻿using System;
using System.Collections.Generic;

namespace AuthenticationJWTAuthorizationRole.Models
{
    public partial class TblProduct
    {
        public int Code { get; set; }
        public string? Name { get; set; }
        public decimal? Amount { get; set; }
    }
}
