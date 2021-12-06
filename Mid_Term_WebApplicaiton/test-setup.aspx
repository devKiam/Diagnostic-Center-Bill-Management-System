<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test-setup.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Test_Setup_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <h2>Test Setup</h2>
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
            <asp:Label ID="Label1" runat="server" Text="Test Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="testNameTextBox" runat="server" Height="25px" Width="225px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Fee"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="feeTextBox" runat="server" Height="25px" Width="225px"></asp:TextBox>
            &nbsp;BDT<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Test Type"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="testTypeDropDownList" runat="server" Height="25px" Width="225px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <br />
            <br />
            <asp:Label ID="displayLabel" runat="server"></asp:Label>

            <br />
            <br />

            <div class="table">
                <asp:GridView ID="testSetupGridView" AutoGenerateColumns="False" CssClass="gridView" runat="server">
                    <Columns>
                        <asp:TemplateField HeaderText="SN" ItemStyle-Width="30px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Test Name" ItemStyle-Width="250px">
                            <ItemTemplate>
                                <asp:Label Text='<%#Eval("test_name") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fee" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label Text='<%#Eval("fee") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Test Type" ItemStyle-Width="100px">
                            <ItemTemplate>
                                <asp:Label Text='<%#Eval("test_type") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>

    </form>
</body>
</html>
