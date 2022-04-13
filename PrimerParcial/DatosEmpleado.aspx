<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosEmpleado.aspx.cs" Inherits="PrimerParcial.DatosEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo de Empleado<asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox><br/>
                        Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br/>
               Horas Laboradas<asp:TextBox ID="txtHoras" runat="server"></asp:TextBox><br/>
                 Salario Bruto<asp:TextBox ID="txtSalarioBruto" runat="server"></asp:TextBox><br/> 
                              <asp:Button ID="btn_Incluir" runat="server" Text="Incluir" OnClick="btn_Incluir_Click" /><br/>
        </div>
    </form>
</body>
</html>
