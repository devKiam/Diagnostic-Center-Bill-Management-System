<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test-type-setup.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Test_Type_Setup_WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
</head>
<body class="home">
    <form id="form1" runat="server">
        <div>
            <h2>Test Type Setup</h2>
             <div class="navbar">
                <div class="dropdown">
                    <asp:Button Text="Home" runat="server" class="dropbtn" PostBackUrl="~/home.aspx" />
                </div>
                <div class="dropdown">
                    <button class="dropbtn">Setup</button>
                    <div class="dropdown-content">
                        <a href="test-type-setup.aspx">Test Type</a>
                        <a href="test-setup.aspx">Test</a>
                    </div>
                </div>
                <div class="dropdown">
                    <button class="dropbtn">Test Request</button>
                    <div class="dropdown-content">
                        <a href="test-request-entry.aspx">Entry</a>
                        <a href="payment.aspx">Payment</a>
                    </div>
                </div>
                <div class="dropdown">
                    <button class="dropbtn">Report</button>
                    <div class="dropdown-content">
                        <a href="test-wise-report.aspx">Test Wise</a>
                        <a href="type-wise-report.aspx">Type Wise</a>
                        <a href="unpaid-bill-report.aspx">Unpaid Bill</a>
                    </div>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
            <asp:Label ID="typeNameLabel" runat="server" Text="Type Name"></asp:Label>
            &nbsp;
            <asp:TextBox ID="typeNameTextBox" runat="server" Height="25px" Width="225px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <br />
            <br />
            <asp:Label ID="messageLabel" runat="server"></asp:Label>

            <div class="table">
                <asp:GridView ID="TestTypeGridView" AutoGenerateColumns="False" CssClass="gridView table table-striped table-dark table-wrapper-scroll-y my-custom-scrollbar table-striped mb-0" Style="margin-top: 60px;" runat="server">
                    <Columns>
                        <asp:TemplateField HeaderText="SN" ItemStyle-Width="30px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Test Type" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <asp:Label Text='<%#Eval("type_name") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>

        <div>
        </div>

    </form>
</body>
</html>
