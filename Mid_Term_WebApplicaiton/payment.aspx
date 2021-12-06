<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="Mid_Term_WebApplicaiton.Payment_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Home-WebForm-StyleSheet.css">
    <!<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style type="text/css">
        .text-input {
            height: 78px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="home">
            <h2>Payment</h2>
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
            <div class="text-input">
                <asp:Label CssClass="Label-cl" for="billNoInput" ID="billNoLabel" runat="server" Text="Bill No"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="billNoInput" class="input" runat="server" placeholder="Enter Bill Number"></asp:TextBox>
                <br />
            </div>
            <div class="text-input">
                <asp:Label class="Label-cl color" ID="fdff" Text="OR" runat="server"></asp:Label>
                <br />
            </div>
            <div class="text-input">
                <asp:Label for="mobileNoInput" class="Label-cl" ID="Label1" runat="server" Text="Mobile Number"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="mobileNoInput" class="input" runat="server" placeholder="Enter Mobile Number"></asp:TextBox>
                <br />
            </div>
            <div class="text-input">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="searchButton" class="text-center btnn" runat="server" Text="SEARCH" OnClick="searchButton_Click" />
                <br />
            </div>
            <div class="text-input">
                <asp:Label class="Label-cl color" ID="outputLabel" runat="server"></asp:Label>
                <br />
            </div>
            <div class="text-input">
                <asp:Label for="amountInput" class="Label-cl" ID="Label2" runat="server" Text="Amount"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="amountInput" class="input" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
            </div>
            <div class="text-input">
                <asp:Label for="dueDateInput" class="Label-cl" ID="Label3" runat="server" Text="Due Date"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="dueDateInput" Type="text" class="input" runat="server"></asp:TextBox>
                <br />
            </div>
            <div class="text-input">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="payButton" class="text-center btnn mb" runat="server" Text="PAY AMOUNT" OnClick="payButton_Click" Width="98px" />
            </div>
        </div>

    </form>
</body>
</html>
