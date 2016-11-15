using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chitiet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Request.QueryString["Ma"] +"<Br>");
        Response.Write(Request.QueryString["Ten"] + "<Br>");
        Response.Write(Request.QueryString["Tuoi"] + "<Br>");
    }
}