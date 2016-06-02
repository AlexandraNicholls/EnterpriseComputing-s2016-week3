using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
*@File Name: Contact.aspx.cs
*@Author: Alex Nicholls
*@Site: Personal Profile
*@Date: June 1, 2016
*/

namespace EnterpriseWeek3
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // replace with email processing code to be fancy-pants
            Response.Redirect("Default.aspx");
        }
    }
}