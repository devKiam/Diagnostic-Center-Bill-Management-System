<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Home_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage - Dignostic Centre Bill Management System</title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
</head>
<body>
    <form id="form1" runat="server">

        <div class="home">
            <h2>Diagnostic Center Bill Management System</h2>
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

            <img src="Images/slide01.jpg" class="responsive" alt="Medical"/>

        </div>

    </form>
</body>
</html>
