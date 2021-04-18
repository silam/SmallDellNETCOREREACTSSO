<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client1Login.aspx.cs" Inherits="SSOTestClientApp1.Client1Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblMain" runat="server" Font-Bold="True" Font-Names="Broadway" 
                        Font-Size="X-Large">Client 1 Application</asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Login ID="LoginControl" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" 
                         onauthenticate="LoginControl_Authenticate1">
                        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
                </td>
            </tr>
        </table>
       
    
    </div>
    </form>
</body>
</html>
