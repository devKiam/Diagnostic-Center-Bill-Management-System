<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test-request-entry.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Test_Request_Entry_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
    <style type="text/css">
        #dateOfBirthTextBox {
            width: 228px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <h2>&nbsp; Test Request Entry</h2>
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
            <asp:Label ID="Label1" runat="server" Text="Name of the Patient"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="patientNameTextBox" runat="server" Height="25px" Width="226px"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Date of Birth"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <input type="date" id="dateOfBirthTextBox" runat="server" name="fromDate">
            <br />
            <br />
            &nbsp;
            <asp:Label ID="Label4" runat="server" Text="Mobile No."></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="mobileNoTextBox" runat="server" Height="25px" Width="230px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Select Test"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="testTypeDropDown" runat="server" OnSelectedIndexChanged="testTypeDropDown_SelectedIndexChanged" AutoPostBack="true" Height="25px" Width="238px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;<br />
            <br />
            &nbsp;&nbsp;
            &nbsp;<asp:Label ID="Label5" runat="server" Text="FEE"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="feeTextBox" runat="server" Height="25px" Width="232px"></asp:TextBox>
            &nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="addButton" runat="server" Text="ADD" OnClick="addButton_Click" />
            <br />
            <br />
            <asp:Label ID="displayLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />

            <div class="table">
                <asp:GridView ID="testRequestGridView" AutoGenerateColumns="False" CssClass="gridView" runat="server">
                    <Columns>
                        <asp:TemplateField HeaderText="SN" ItemStyle-Width="30px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField ItemStyle-Width="150px" DataField="test_name" HeaderText="Test Name" />
                        <asp:BoundField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataField="fee" HeaderText="Fee" />
                    </Columns>
                </asp:GridView>

            </div>


            <br />
            <asp:Label ID="Label6" runat="server" Text="Total"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="totalTextBox" runat="server" Height="23px" Width="214px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />

        </div>
    </form>
</body>
</html>
