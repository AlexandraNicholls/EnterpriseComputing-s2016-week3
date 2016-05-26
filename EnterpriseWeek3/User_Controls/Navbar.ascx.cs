using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
*@Author: Alex Nicholls
*@date May 26, 2016
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
        *
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
                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}