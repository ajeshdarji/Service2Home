﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Service2Home
{
    public partial class servicecompleted : System.Web.UI.Page
    {
        connectionclass connection = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            String pend = "select * from service_request where serviceid=" + Session["uid"] + " and status='completed' or status='cancelled' ";
            DataSet dr = connection.Fun_dataadapter(pend);
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}