<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HealthGuardApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Log in</h2>
    <p>User Name: <asp:TextBox ID="txtUserName" runat="server" Placeholder="UserName" /></p>
    
    <p>Password: <asp:TextBox ID="txtPassword" runat="server" Placeholder="Password" /></p>
   
    
    <asp:RadioButtonList ID="Insurance" runat="server" RepeatDirection="Horizontal">
        
    <asp:ListItem>Remember me next time.</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="loginSubmit_Click" /> 
                <a href="MyProfile.aspx" id="userPageID" style="display:none; float:right;" runat="server"><i class="fa fa-user"></i></a>

     <asp:Label ID="LblResult" runat="server" Text="Result" >

    </asp:Label>


</asp:Content>
