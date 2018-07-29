<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="HealthGuardApp.Appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <p> &nbsp;</p>
    <h2 style="text-align:center"> Request Appointment</h2>

    <table>

            <tr>
                <td>First Name: <asp:TextBox ID="txtFirstName" runat="server" Width="105px" ></asp:TextBox>*
                </td>
                    </tr>
                <tr>
                <td class="auto-style4">Last Name: <asp:TextBox ID="txtLastName" runat="server" Width="127px"></asp:TextBox>*
                    </td>
                    </tr>
            <tr>
                    <td style="height: 30px">Phone Number: <asp:TextBox ID="txtPhoneNumber" runat="server" ></asp:TextBox>*
                        </td>
                </tr>
                <tr>
                    <td>Address: <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>*
                        </td>
                </tr>
            <tr>
                    <td>Zip: <asp:TextBox ID="txtZip" runat="server" ></asp:TextBox>*
                        </td>
                </tr>
                <tr>
                    <td>Country: <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>*
                        </td>
            </tr>
          <tr>
            <td >Time: <asp:TextBox ID="txtTime" runat="server" ></asp:TextBox>*
                </td>
        </tr>
          <tr>
            <td >Doctor: <asp:TextBox ID="txtDoctorName" runat="server" ></asp:TextBox>*
                </td>
        </tr>
        <tr>
            <td >Descript: <asp:TextBox ID="Content" runat="server" ></asp:TextBox>*
                </td>
        </tr>
        <tr>
            <td >Do you currently have insurance?  
                <asp:RadioButtonList ID="Insurance" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                 <asp:Button ID="Button1" runat="server" Text="Submit"  />
                </td>
        </tr>
        </table>
        
       
        
    <br />
        <h4></h4>
</asp:Content>
