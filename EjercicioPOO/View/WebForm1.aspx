<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioPOO.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <div class="row">
                <asp:Label CssClass="col-6" ID="Label1" runat="server" Text="Label">Numero de cuenta:</asp:Label>
                <asp:TextBox CssClass="col-6" ID="txtNumeroCuenta" runat="server"></asp:TextBox>
            </div>
            <br />

            <div class="row">
                <asp:Label CssClass="col-6" ID="Label2" runat="server" Text="Label">Nombre:</asp:Label>
                <asp:TextBox CssClass="col-6" ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <br />

            <div class="row">
                <asp:Label CssClass="col-6" ID="Label3" runat="server" Text="Label">Saldo inicial:</asp:Label>
                <asp:TextBox CssClass="col-6" ID="txtSaldo" runat="server"></asp:TextBox>
            </div>
            <br />

            <div class="row">
                <asp:Label CssClass="col-6" ID="Label4" runat="server" Text="Label">Tasa de interes:</asp:Label>
                <asp:TextBox CssClass="col-6" ID="txtInteres" runat="server"></asp:TextBox>
            </div>
            <br />
            <asp:Label CssClass="text-success" ID="lblInformacion" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button CssClass="btn btn-success text-light" ID="Button1" runat="server" Text="Crear Cuenta" OnClick="Button1_Click" />


            <div>
                <br />
                <div class="row">
                    <asp:Label ID="Label5" runat="server" Text="Accion"></asp:Label>
                    <asp:DropDownList ID="dropAccion" runat="server">
                        <asp:ListItem>Retirar</asp:ListItem>
                        <asp:ListItem>Depositar</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <br />
                <div class="row">
                    <asp:Label ID="Label6" runat="server" Text="Monto"></asp:Label>
                    <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
                </div>
                <br />
                <asp:Label CssClass="text-success" ID="lblInformacionRetiroDeposito" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnAccion" runat="server" Text="Realizar" OnClick="btnAccion_Click" />
            </div>
            <div>
                <br />
                <asp:GridView ID="grdTransacciones" CssClass="table" runat="server"></asp:GridView>
            </div>
            <div>
                <br />
                <div class="row">
                    <asp:Label CssClass="col-6" ID="Label7" runat="server" Text="Tiempo para proyeccion(años)"></asp:Label>
                    <asp:TextBox CssClass="col-6" ID="txtTiempo" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="lblInformacionProyeccion" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="btnRealizarProyeccion" runat="server" Text="Calcular Proyeccion" OnClick="btnRealizarProyeccion_Click" />
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>
</body>
</html>
