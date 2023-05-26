<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUsuario.aspx.cs" Inherits="ClienteUsuario.FrmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="styles.css"/>
</head>
<body>
    
    <form id="loginForm" runat="server">
    <div class="login-container">
      <h2>Iniciar sesión</h2>
      <div class="form-group">
        <label for="username">Usuario:</label>
        <asp:TextBox ID="txtUsuario" runat="server" placeholder="Ingresa tu nombre de usuario"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="password">Contraseña:</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Ingresa tu contraseña"></asp:TextBox>
      </div>
      <asp:Button ID="btnAcceder" runat="server" Text="Iniciar sesión" OnClick="btnAcceder_Click" />
      <asp:Label runat="server" ID="labelMensaje"></asp:Label>
    </div>
  </form>
</body>
</html>
