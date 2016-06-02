using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
*@File Name: 
*@Author: Alex Nicholls
*@Date: May 28, 2016
*/

namespace EnterpriseWeek3
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
        * This  method adds a CSS class of "active" to list items, relative to navigation links
        * to show the user that they are on this page.
        *@method SetActivePage
        *@return void
        */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    Home.Attributes.Add("class", "active");
                    break;
                case "About":
                    About.Attributes.Add("class", "active");
                    break;
                case "Products":
                    Products.Attributes.Add("class", "active");
                    break;
                case "Services":
                    Services.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}