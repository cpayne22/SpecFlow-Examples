﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookshop.Models
{
    partial class OrderLine
    {
        public decimal Price
        {
            get
            {
                return Quantity * Book.Price;
            }
        }
    }
}
