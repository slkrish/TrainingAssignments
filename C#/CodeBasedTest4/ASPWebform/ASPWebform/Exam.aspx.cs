using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebform
{
    public partial class Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "NISSAN-GTR", "PORSCHE-CAYMAN", "DODGE-CHARGER", "HEADPHONES", "IPHONE13" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Photos/" + str + ".jpg";
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "NISSAN-GTR")
            {
                TextBox1.Text = "Rs. 40000000";
            }
            else if (DropDownList1.Text == "PORSCHE-CAYMAN")
            {
                TextBox1.Text = "Rs. 2220000";
            }
            else if (DropDownList1.Text == "DODGE-CHARGER")
            {
                TextBox1.Text = "Rs. 35000000";
            }
            else if (DropDownList1.Text == "HEADPHONES")
            {
                TextBox1.Text = "Rs. 18000";
            }
            else
            {
                TextBox1.Text = "Rs. 74000";
            }
        }
    }
}