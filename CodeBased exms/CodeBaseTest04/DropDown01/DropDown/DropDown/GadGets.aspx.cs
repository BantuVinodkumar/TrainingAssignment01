using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDown
{
    public partial class GadGets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Camera", "Headset", "Laptop", "SmartWatch", "Speaker" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jpg";



        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Camera")
            {
                TextBox1.Text = "Rs 110000 /-";
            }
            else if (DropDownList1.Text == "Headset")
            {
                TextBox1.Text = "Rs 2000 /-";
            }
            else if (DropDownList1.Text == "Laptop")
            {
                TextBox1.Text = "Rs 75000 /-";
            }
            else if (DropDownList1.Text == "Smartwatch")
            {
                TextBox1.Text = "Rs 5000 /-";
            }
            else if (DropDownList1.Text == "Speaker")
            {
                TextBox1.Text = "Rs 8000 /-";
            }



            else
            {
                TextBox1.Text = "Rs 50000 /-";
            }
        }
    }
}