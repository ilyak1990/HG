<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HealthGuardApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <table>

<tr>

<td>Login: <asp:TextBox ID="txtRegisterEmail" runat="server" Width="105px" ></asp:TextBox>*

</td>

</tr>

<tr>

<td class="auto-style4">Password: <asp:TextBox ID="txtRegisterPassword" runat="server" Width="127px"></asp:TextBox>*

</td>

</tr>

　

<tr>

<td class="auto-style4">Password Confirmation: <asp:TextBox ID="txtRegisterPassword2" runat="server" Width="127px"></asp:TextBox>*

</td>

</tr>

<tr>

　

<td style="height: 30px">Name: <asp:TextBox ID="txtRegisterName" runat="server" ></asp:TextBox>*

</td>

</tr>

<tr>

<td class="auto-style4">Email: <asp:TextBox ID="txtRegisterEmailAddress" runat="server" Width="127px"></asp:TextBox>*

</td>

</tr>

　

</table>

<asp:Button ID="Button2" runat="server" Text="Submit" OnClick="btn_Register_Submit" />

<asp:Button ID="Button" runat="server" Text="test" OnClick="jawn_click" />

<table>

<tr>

<asp:TextBox ID="textBox1" runat="server" />

<asp:Label ID="label1" runat="server" />

</tr>

</table>

</asp:Content>
