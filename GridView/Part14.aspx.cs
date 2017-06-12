using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part14 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //row被删除
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        lblMessage.Visible = true;
        if (e.AffectedRows > 0)
        {
            lblMessage.Text = "Employee row with EmployeeID = \""
                + e.Keys[0].ToString()
                + "\" is succesfully deleted";
            lblMessage.ForeColor = System.Drawing.Color.Navy;
        }
        else
        {
            lblMessage.Text = "Employee Row with EmployeeID = \""
                + e.Keys[0].ToString() + "\" is not deleted due to data conflict";
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}