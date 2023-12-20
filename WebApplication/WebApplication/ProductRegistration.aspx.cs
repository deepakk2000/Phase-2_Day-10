using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = "<br/>Product Registration Success!!!";
            Label1.Text = "<br/>Product Name" + TextBox2.Text;
            Label1.Text += "<br/>Catagory" + DropDownList1.Text;
            Label1.Text += "<br/>Price" + TextBox3.Text;
            Label1.Text += "<br/>Product Description" + TextBox4.Text;
            Label1.Text += "<br/>Product Release Date" + Calendar1.SelectedDate.ToShortDateString();

        }
    }
}