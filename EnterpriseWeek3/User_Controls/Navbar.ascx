<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="EnterpriseWeek3.Navbar" %>
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx">
                <i class="fa fa-fort-awesome fa-lg"></i> ASP.NET</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="Home" runat="server"><a href="Default.aspx"><i class="fa fa-bed fa-lg"></i> Home</a></li>
                <li id="About" runat="server"><a href="About.aspx"><i class="fa fa-book fa-lg"></i> About Us</a></li>
                <li id="Products" runat="server"><a href="Products.aspx"><i class="fa fa-archive fa-lg"></i> Products</a></li>
                <li id="Services" runat="server"><a href="Services.aspx"><i class="fa fa-desktop fa-lg"></i> Services</a></li>
                <li id="Contact" runat="server"><a href="Contact.aspx"><i class="fa fa-phone fa-lg"></i> Contact Us</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>
