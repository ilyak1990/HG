<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statement.aspx.cs" Inherits="HealthGuardApp.Statement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      
    <p> &nbsp;</p>
    <h2 style="text-align:center">Billing</h2>
    <table>
        <tr>
             <td>Patient Name: <asp:TextBox ID="txtFirstName" runat="server" Width="105px" ></asp:TextBox>*</td>
        
             <td>Patient ID: <asp:TextBox ID="txtID" runat="server" Width="105px" ></asp:TextBox>*</td>
             <td><asp:Button ID="Button1" runat="server" Text="Check"  /></td>
        </tr>
        
             
        
        </table>
    <br />
    <br />
    <br />
    <table border="1" id="TableRPT">
        <tr>
            <th> Medicine </th>
            <th> Number</th>
            <th> Price</th>
            
        </tr>
 
        <tr>
            <th><asp:TextBox ID="txt" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt1" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt2" runat="server" ></asp:TextBox></th>
            
        </tr>
        <tr>
            <th><asp:TextBox ID="txt3" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt4" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt5" runat="server" ></asp:TextBox></th>
            
        </tr>
        <tr>
            <th><asp:TextBox ID="txt6" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt7" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt8" runat="server" ></asp:TextBox></th>
            
        </tr>
        <tr>
            <th><asp:TextBox ID="txt9" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt10" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt11" runat="server" ></asp:TextBox></th>
            
        </tr>
        <tr>
             <td>Total: <asp:TextBox ID="txttotal" runat="server" Width="105px" ></asp:TextBox></td>
        </tr>

           </table>     
    
</asp:Content>
