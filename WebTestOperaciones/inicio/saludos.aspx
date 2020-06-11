<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="saludos.aspx.cs" Inherits="WebTestOperaciones.inicio.saludos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese tu nombre
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblSaludos" runat="server" Text="lblSaludos"></asp:Label>
        <br />
        El resultado de la sumatoria del vector es
        <asp:TextBox ID="txtR" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
        </p>
    </form>
</body>
</html>
