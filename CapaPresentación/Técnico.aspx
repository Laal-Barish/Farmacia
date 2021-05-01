<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Técnico.aspx.cs" Inherits="CapaPresentación.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Mantenimiento a la clase Técnico<br />
            <br />
            Apellidos:
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombres:
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <br />
            <br />
            Experiencia laboral:
            <asp:TextBox ID="txtExperienciaLaboral" runat="server"></asp:TextBox>
            <br />
            <br />
            Estudios:
            <asp:TextBox ID="txtEstudios" runat="server"></asp:TextBox>
            <br />
            <br />
            Domicilio:&nbsp;
            <asp:TextBox ID="txtDomicilio" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLeer" runat="server" OnClick="btnLeer_Click" Text="Leer" style="height: 26px" />
            <asp:Button ID="btnEscribir" runat="server" OnClick="btnEscribir_Click1" Text="Escribir" />
            <br />
            <br />
            <asp:Button ID="btnControlarVentas" runat="server" Text="Controlar Ventas" OnClick="btnControlarVentas_Click" />
            <asp:Button ID="btnAtenderVentas" runat="server" Text="Atender Ventas" OnClick="btnAtenderVentas_Click" />
            <asp:Button ID="btnBalanceDiario" runat="server" Text="Balance diario" OnClick="btnBalanceDiario_Click" />
            <br />
            <asp:Label ID="lblRespuesta" runat="server" Text="..."></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
