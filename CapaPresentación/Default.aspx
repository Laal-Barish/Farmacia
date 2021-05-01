<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CapaPresentación.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 894px;
            height: 473px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnTecnico" runat="server" OnClick="btnTecnico_Click" Text="Técnico" />
            <asp:Button ID="btnAdministrador" runat="server" Text="Administrador" OnClick="btnAdministrador_Click" />
            <asp:Button ID="Button3" runat="server" Text="Químico-farmacéutico" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Button" />
        </div>
    </form>
    <p>
        <img alt="" class="auto-style1" src="Farmacia-Jaén_27.08.15-680x381.jpg" /></p>
</body>
</html>
