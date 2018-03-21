<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
 
<form id="form1" runat="server">



        <table class="style1">
            <tr>
                <td>
                    Hello, This is an exmple for generating PDF from HTML</td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="btnReport" runat="server" Text="Download Report as PDF" onclick="btnReport_Click" />  


                </td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="btnHtmlReport" runat="server" Text="View Report as HTML" 
                        onclick="btnHtmlReport_Click" />  


                </td>
            </tr>
        </table>


</form>
</body>
</html>