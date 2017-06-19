using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "") {
            lblPrompt.Text = "Plase key your Name";
            return;
        }
        if (txtPassword.Text.Trim() == "") {
            lblPrompt.Text = "Plase key your Passeord";
            return;
        }
        Session["UserName"] = txtUserName.Text;
        Response.Redirect("secret.aspx");
        string s = Session["UserName"].ToString();
        if (s == null) {
            Response.Redirect("Default.aspx");
        } else {
            Response.Redirect(s);
        }


    }

    protected void btnOut_Click(object sender, EventArgs e) {
        Session.Abandon();
    }
}