<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="HealthGuardApp.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <html>
      <head>
    <h2>My Profile</h2>
          </head>
          <body>
              <section>
                       <article id ="SessionTest">
                         <%--<asp:HyperLink ID="pngLogo" runat="server" ImageUrl="~/Images/Logo.png" Width="100" Height="100" />  --%> 
                           <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit"/>
                             <asp:Button ID="btnGet" runat="server" OnClick="btnGetInfo_Click" Text="Load My Profile"/>
                                <asp:Label ID="LblResult" runat="server" Text="Result" >
                                    </asp:Label>
                          <p>Test1: <asp:TextBox ID="txtName" runat="server" Text="Name" /></p>  
                          <p>Test2: <asp:TextBox ID="txtGender" runat="server" Text="Gender"/></p>
                          <p>Test3: <asp:TextBox ID="txtEthnicity" runat="server" Text="Ethnicity"/></p> 
                          <p>Test4: <asp:TextBox ID="txtAge" runat="server" Text="Age" /></p>   
                          <p>Birth Date: <asp:TextBox ID="txtBirth" runat="server" Text="Age" /></p> 
                          <p>Address: <asp:TextBox ID="txtAddress" runat="server" Text="Address" /> 
                              <asp:TextBox ID="txtAptNumber" runat="server" Text="Apt Number" />
                              <asp:TextBox ID="txtStreet" runat="server" Text="Street" />
                              <asp:TextBox ID="txtZip" runat="server" Text="Zip Code" />
                              <asp:TextBox ID="txtCity" runat="server" Text="City" />
                          </p>
                          <p>Blood Type   <asp:Label ID="lblBlood" runat="server" Text="Blood Type" /></p>
                          <p>Allergies:  <asp:Label ID="lblAllergies" runat="server" Text="Test" /></p>
                          <p>Pre-Existing Problems: <asp:Label ID="lblPreexisting" runat="server" Text="Test" /></p>
                          <p>Procedure History: <asp:Label ID="lblProcedure" runat="server" Text="Test" /></p>
                          <p>Vitals</p> 
                             <ul style="list-style-type:none">
                                  <li>Body Temperature: <asp:Label ID="lblBodyTemp" runat="server" Text="Test" /></li>
                                  <li>Blood Pressure: <asp:Label ID="lblBldPressure" runat="server" Text="Test" /></li>
                                  <li>Pulse: <asp:Label ID="lblPulse" runat="server" Text="Test" /></li>
                                  <li>Breathing Rate: <asp:Label ID="lblBreathingRate" runat="server" Text="Test" /></li>
                           </ul>
                           <p>Medication: <asp:Label ID="lblMedication" runat="server" Text="Test" /></p>
                           <p>Immunization History</p>
                            <ul style="list-style-type:none">
                                <li>DTaP:  <asp:Label ID="lblDTaP" runat="server" Text="Test" /></li>
                                <li>Hepatitis A: <asp:Label ID="lblHA" runat="server" Text="Test" /></li>
                                <li>Hepatitis B: <asp:Label ID="lblHB" runat="server" Text="Test" /></li>
                                <li>HIB Unspec:  <asp:Label ID="lblHIB" runat="server" Text="Test" /></li>
                                <li>Influenza:  <asp:Label ID="lblInfluenza" runat="server" Text="Test" /></li>
                                <li>IPV: <asp:Label ID="lblIPV" runat="server" Text="Test" /></li>
                                <li>Rotavirus(3 doses):  <asp:Label ID="lblRotavirus" runat="server" Text="Test" /></li>
                                <li>Varicella: <asp:Label ID="lblVaricella" runat="server" Text="Test" /></li>
                                <li>Ordered: <asp:Label ID="lblOrdered" runat="server" Text="Test" /></li>
                            </ul>
                           <p>Social History: <asp:Label ID="lblSocial" runat="server" Text="Test" /></p>
                           <p>Family History: <asp:Label ID="lblFamily" runat="server" Text="Test" /></p>
      
                                
                      </article>
                  </section>
          </body>
      <aside>
          <h2> Action Center</h2>
      </aside>
 
  </html>


</asp:Content>
