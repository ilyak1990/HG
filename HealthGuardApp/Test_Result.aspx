<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test_Result.aspx.cs" Inherits="HealthGuardApp.Test_Result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <html>
      <head>
           <h2>Test Results</h2>
      </head>
      <body>
          <section>
              <article style="text-align:center">
         <tr>
             <td>Patient Name: <asp:TextBox ID="txtFirstName" runat="server" Width="105px" ></asp:TextBox></td>
        
             <td>Patient ID: <asp:TextBox ID="txtID" runat="server" Width="105px" ></asp:TextBox></td>
        </tr>
                  <asp:Button ID="Button1" runat="server" Text="Check"  />
                  <h3>Latest Lab results</h3>
                  <table border="1" style="width:50%" >
                       <tr>
            <th> Test </th>
            <th> Date</th>
            <th> View</th>          
        </tr>
        <tr>
            <th><asp:TextBox ID="txt" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt1" runat="server" ></asp:TextBox></th>
            <th><asp:TextBox ID="txt2" runat="server" ></asp:TextBox></th>
            
        </tr>
            
       
                  </table>
              </article>
          </section>
      </body>
  </html>

</asp:Content>
