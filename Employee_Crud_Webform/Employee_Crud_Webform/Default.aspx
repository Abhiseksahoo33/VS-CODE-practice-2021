<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Employee_Crud_Webform._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color:lightblue">
    <div>
      <div  style="font-size:x-large ; background-color:blue ; color:white" align="center">Employee Info Manage Page </div>
      <br />

      <table  class="nav-justified">
          <tr>
              <td>&nbsp;</td>
              <td>Employee ID</td>
              <td style="width: 729px">
                  <asp:TextBox ID="TextBox4" runat="server" style="margin-top: 0" Width="105px"></asp:TextBox>
                  <asp:Button ID="Button5" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="GETButton5_Click" style="margin-left: 18px" Text="GET" Width="63px" />
              </td>
          </tr>
          <tr>
              <td style="width: 136px; height: 22px"></td>
              <td style="width: 112px; height: 22px">Name</td>
              <td style="height: 22px; width: 729px;">
                  <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
              </td>
              <td style="height: 22px"></td>
              <td style="height: 22px"></td>
          </tr>
          <tr>
              <td style="width: 136px; height: 22px;"></td>
              <td style="width: 112px; height: 22px;">Department</td>
              <td style="width: 729px; height: 22px;">
                  <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="113px">
                      <asp:ListItem>.Net</asp:ListItem>
                      <asp:ListItem>C</asp:ListItem>
                      <asp:ListItem>C++</asp:ListItem>
                      <asp:ListItem>java</asp:ListItem>
                      <asp:ListItem>VB</asp:ListItem>
                      <asp:ListItem>Python</asp:ListItem>
                      <asp:ListItem>PHP</asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td style="height: 22px"></td>
              <td style="height: 22px"></td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">Designation</td>
              <td style="width: 729px">
                  <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="113px">
                      <asp:ListItem>Employee</asp:ListItem>
                      <asp:ListItem>Project Manager</asp:ListItem>
                      <asp:ListItem>Intern</asp:ListItem>
                      <asp:ListItem>Operation Executive</asp:ListItem>
                  </asp:DropDownList>
                  <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="165px">
                      <Fields>
                          <asp:BoundField DataField="Empno" HeaderText="Empno" SortExpression="Empno" />
                          <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                          <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                          <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                          <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
                      </Fields>
                  </asp:DetailsView>
                  <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
                      <Columns>
                          <asp:BoundField DataField="Empno" HeaderText="Empno" SortExpression="Empno" />
                          <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                          <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                          <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                          <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
                      </Columns>
                  </asp:GridView>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" ProviderName="<%$ ConnectionStrings:sqlpracticeConnectionString.ProviderName %>" SelectCommand="SELECT [Empno], [name], [dept], [desig], [basic] FROM [Emp]"></asp:SqlDataSource>
              </td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">Basic</td>
              <td style="width: 729px">
                  <asp:TextBox ID="TextBox3" runat="server" Width="105px"></asp:TextBox>
              </td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">&nbsp;</td>
              <td style="width: 729px">&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px; height: 29px"></td>
              <td style="width: 112px; height: 29px"></td>
              <td style="height: 29px; width: 729px;">
                  <asp:Button ID="Button1" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Insert" />
                  <asp:Button ID="Button2" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click" OnClientClick="return confirm('are you sure to update ? Click OK to confirm!..')" style="margin-left: 18px" Text="Update" />
                  <asp:Button ID="Button3" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" OnClientClick="return confirm('are you sure to delete ? Click OK to confirm!..')" style="margin-left: 18px" Text="Delete" />
                  <asp:Button ID="Button4" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" style="margin-left: 18px" Text="Search" />
                  <asp:Button ID="Button6" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="ShowAllButton6_Click" style="margin-left: 18px" Text="Show All" />
                  <asp:Button ID="Button7" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="DeleteAllButton7_Click" style="margin-left: 18px" Text="Delete All" />
                  <asp:Button ID="Button8" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="False" Font-Size="Medium" ForeColor="White" OnClick="RDLCButton8_Click" style="margin-left: 18px" Text="RDLC" />
              </td>
              <td style="height: 29px"></td>
              <td style="height: 29px"></td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">&nbsp;</td>
              <td style="width: 729px">&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">&nbsp;</td>
              <td style="width: 729px">&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">&nbsp;</td>
              <td style="width: 729px">&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td style="width: 136px">&nbsp;</td>
              <td style="width: 112px">&nbsp;</td>
              <td style="width: 729px">
                  <asp:GridView ID="GridView1" runat="server" Width="686px">
                  </asp:GridView>
              </td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
          </tr>
      </table>

        

  </div>
        <rsweb:reportviewer ID="rv" runat="server" Width="986px" style="margin-left: 125px; margin-right: 0px;" Height="493px"></rsweb:reportviewer>
        </div>

        

      
     
   
  </asp:Content>

