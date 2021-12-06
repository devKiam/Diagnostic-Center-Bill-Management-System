<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unpaid-bill-report.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Unpaid_Bill_Report_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <h2>Unpaid Bill Report</h2>
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
            <label for="birthday">From Date:&nbsp; </label>
            &nbsp;<input type="date" runat="server" id="fromDateTextBox" name="fromDate">
            <label for="birthday">
                <br />
                <br />
                To Date:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="date" runat="server" id="toDateTextBox" name="toDate">
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <br />
            <br />
            <br />


            <div class="table">
                <asp:GridView ID="unpaidBillReportGridView" AutoGenerateColumns="False" CssClass="gridView" runat="server">
                    <Columns>
                        <asp:TemplateField HeaderText="SN" ItemStyle-Width="30px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center" DataField="bill_no" HeaderText="Bill No" />
                        <asp:BoundField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataField="name" HeaderText="Patient Name" />
                        <asp:BoundField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataField="mobile_no" HeaderText="Mobile No" />
                        <asp:BoundField ItemStyle-Width="150px" ItemStyle-HorizontalAlign="Center" DataField="bill_amount" HeaderText="Bill Amount" />
                    </Columns>
                </asp:GridView>
            </div>

            <br />

            <br />
            Total&nbsp;&nbsp;
            <asp:TextBox ID="totalTextBox" runat="server"></asp:TextBox>
            &nbsp;BDT<br />
            <br />
            <asp:Button ID="pdfButton" runat="server" OnClick="pdfButton_Click" Text="PDF" />
        </div>
    </form>
</body>
</html>
