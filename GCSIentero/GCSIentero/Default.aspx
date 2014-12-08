<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GCSIentero._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 126px;
        }
        .auto-style2 {
            width: 157px;
        }
        .auto-style3 {
            width: 126px;
            height: 23px;
        }
        .auto-style4 {
            width: 157px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Ingrese un Valor"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Par ?" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MasRepetido" />
                </td>
                
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                                
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="EliminarMayor" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mayor" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Ordenado" />
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
