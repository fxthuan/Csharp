using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string value = string.Empty;
        if (RadioButton1.Checked)
        {
            value = RadioButton1.Text;
        }
        if (RadioButton2.Checked)
        {
            value = RadioButton2.Text;
        }
        if (RadioButton3.Checked)
        {
            value = RadioButton3.Text;
        }
        Response.Write(value);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string value = string.Empty;
        if (CheckBox1.Checked)
        {
            value = value + CheckBox1.Text + ";";
        }
        if (CheckBox2.Checked)
        {
            value = value + CheckBox2.Text + ";";
        }
        if (CheckBox3.Checked)
        {
            value = value + CheckBox3.Text + ";";
        }
        value = value.Substring(0, value.Length - 1);
        string[] word = value.Split(';');
        for (int i = 0; i < word.Length; i++)
        {
            Response.Write(word[i]);
        }
        
    }
}