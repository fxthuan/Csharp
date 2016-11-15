using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DropDownList1.Items.Add("Lớp A");
            DropDownList1.Items.Add("Lớp B");
            DropDownList1.Items.Add("Lớp C");
            DropDownList1.Items.Add("Lớp D"); 
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Detail2.aspx?Ma=1&Ten=Tu");
    }
}