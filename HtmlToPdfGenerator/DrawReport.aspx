<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DrawReport.aspx.cs" Inherits="DrawReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
<style TYPE="text/css">
BODY
   {
   font-family:sans-serif;
   font-size:23px;
   }
  th {
    height: 33px;
}
td{
    height: 27px;
}
.gridTexts
    {
        font-family:sans-serif;
		font-size:20px;
    }
</style>
<% if(this.ReportType=="PDF") { %>
<style TYPE="text/css">
.pdfPages
    {
        height:1662px;
    }
</style>
<% } %>
</style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="1000px">
    <tr>
    <td>
    <div class="pdfPages">
        <h3>This report was generated on the <%=DateTime.Now %></h3><br />

                <table style="width: 100%;">
                <tr>
                <td width="60%">
                    <img  src="<%=this.ApplicationBaseUrl %>Images/Logo1.jpg" style="height: 204px; width:300px"/>
                </td>
                <td align="right" style="font-size: medium">
                    <img  src="<%=this.ApplicationBaseUrl %>Images/Logo2.jpg" style="height: 100px"/>
                </td>
                </tr>
                </table>

                <table style="width: 100%;">
                <tr>
                <td width="20%">
                    Name :   
                </td>
                <td align="left" style="font-size: medium">
                   Vipin C
                </td>
                </tr>
                <tr>
                <td width="20%">
                   Address : 
                </td>
                <td align="left" style="font-size: medium">
                    house no 17
                </td>
                </tr>
                </table>
        <p>

                                    <asp:GridView ID="grd1" runat="server" AutoGenerateColumns="False" Width="100%" 
                                        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                        CellPadding="3" GridLines="Horizontal">
                                        <AlternatingRowStyle BackColor="#F7F7F7" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="ID" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                        <asp:Label ID="GroupID" runat="server" Text='<%#Eval("ID") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Name" ControlStyle-Width="40%" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                        <strong><asp:Label ID="CategoryName" runat="server" Text='<%#Eval("Name") %>'/></strong><br /><br />
                                                        
                                                </ItemTemplate>

<ControlStyle Width="40%"></ControlStyle>

<ItemStyle VerticalAlign="Top"></ItemStyle>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Description" ControlStyle-Width="20%" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                            <span class="gridTexts"><%#Eval("Description")%></span>
                                                </ItemTemplate>

<ControlStyle Width="20%"></ControlStyle>

<ItemStyle VerticalAlign="Top" HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Remark" ControlStyle-Width="20%" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                            <span class="gridTexts"><%#Eval("Remark") %></span>
                                                </ItemTemplate>

<ControlStyle Width="20%"></ControlStyle>

<ItemStyle VerticalAlign="Top" HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country" ControlStyle-Width="20%" ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>

                                                            <span class="gridTexts"><%#Eval("Country")%></span>
                                                </ItemTemplate>

<ControlStyle Width="20%"></ControlStyle>

<ItemStyle VerticalAlign="Top" HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>
                                            
                                        </Columns>
                                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                                    </asp:GridView>
                                    
      </p>
        
     <p>
     Disclaimer
     <table style="width: 100%;" border="1" bordercolor="blue" bgcolor="#E7E7FF">
                <tr>
                <td>
                    Hello world,  this my demo application to show how can we generate a PDF from HTML 
                </td>
                </tr>
                <tr><td><strong>Vipin Cheriyanveetil</strong></td></tr>
                </table>
     </p>   
    </div>
    
    </td>
    </tr>
    </table>
    </form>
</body>
</html>
