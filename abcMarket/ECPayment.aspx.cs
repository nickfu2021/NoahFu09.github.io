﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevStudio;

namespace abcMarket
{
    public partial class ECPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShopECPay.Payment(Shop.OrderID);
        }
    }
}