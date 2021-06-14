<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Employee_Crud_Webform.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="Empno" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="706px">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                <EditRowStyle BackColor="#2461BF" />
                <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="Empno" HeaderText="Empno" InsertVisible="False" ReadOnly="True" SortExpression="Empno" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                    <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                    <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style1" DataKeyNames="Empno" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." ForeColor="#333333" GridLines="None" Width="623px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="Empno" HeaderText="Empno" ReadOnly="True" SortExpression="Empno" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                    <asp:BoundField DataField="desig" HeaderText="desig" SortExpression="desig" />
                    <asp:BoundField DataField="basic" HeaderText="basic" SortExpression="basic" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlpracticeConnectionString %>" DeleteCommand="DELETE FROM [Emp] WHERE [Empno] = @Empno" InsertCommand="INSERT INTO [Emp] ([name], [dept], [desig], [basic]) VALUES (@name, @dept, @desig, @basic)" ProviderName="<%$ ConnectionStrings:sqlpracticeConnectionString.ProviderName %>" SelectCommand="SELECT [Empno], [name], [dept], [desig], [basic] FROM [Emp]" UpdateCommand="UPDATE [Emp] SET [name] = @name, [dept] = @dept, [desig] = @desig, [basic] = @basic WHERE [Empno] = @Empno">
                <DeleteParameters>
                    <asp:Parameter Name="Empno" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="dept" Type="String" />
                    <asp:Parameter Name="desig" Type="String" />
                    <asp:Parameter Name="basic" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="dept" Type="String" />
                    <asp:Parameter Name="desig" Type="String" />
                    <asp:Parameter Name="basic" Type="Int32" />
                    <asp:Parameter Name="Empno" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
