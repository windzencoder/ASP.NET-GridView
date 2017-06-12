﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part13 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            Control control = e.Row.Cells[0].Controls[0];
            if(control is LinkButton)
            {
                ((LinkButton)control).OnClientClick = "return confirm('Are you sure to delete?')";
            }
        }
    }
}