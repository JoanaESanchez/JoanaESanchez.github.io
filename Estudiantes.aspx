<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estudiantes.aspx.vb" Inherits="ExamenSemestral_JoanaSanchez.Estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style type="text/css">
        .form-style-9 {
            max-width: 450px;
            background: #FAFAFA;
            padding: 30px;
            margin: 50px auto;
            box-shadow: 1px 1px 25px rgba(0, 0, 0, 0.35);
            border-radius: 10px;
            border: 6px solid #305A72;
        }
        .form-style-9 ul {
            padding: 0;
            margin: 0;
            list-style: none;
        }
        .form-style-9 ul li {
            display: block;
            margin-bottom: 10px;
            min-height: 35px;
        }
        .form-style-9 ul li .field-style {
            box-sizing: border-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            padding: 8px;
            outline: none;
            border: 1px solid #B0CFE0;
            -webkit-transition: all 0.30s ease-in-out;
            -moz-transition: all 0.30s ease-in-out;

            -o-transition: all 0.30s ease-in-out;
        }
        .form-style-9 ul li .field-style:focus {
            box-shadow: 0 0 5px #B0CFE0;
            border: 1px solid #B0CFE0;
        }
        .form-style-9 ul li .field-split {
            width: 49%;
        }
        .form-style-9 ul li .field-full {
            width: 100%;
        }
        .form-style-9 ul li input.align-left {
            float: left;
        }
        .form-style-9 ul li input.align-right {
            float: right;
        }
        .form-style-9 ul li textarea {
            width: 100%;
            height: 100px;
        }
        .form-style-9 ul li input[type="button"],
        .form-style-9 ul li input[type="submit"] {
            -moz-box-shadow: inset 0px 1px 0px 0px #3985B1;
            -webkit-box-shadow: inset 0px 1px 0px 0px #3985B1;
            box-shadow: inset 0px 1px 0px 0px #3985B1;
            background-color: #216288;
            border: 1px solid #17445E;
            display: inline-block;
            cursor: pointer;
            color: #FFFFFF;
            padding: 8px 18px;
            text-decoration: none;
            font: 12px Arial, Helvetica, sans-serif;
        }
        .form-style-9 ul li input[type="button"]:hover,
        .form-style-9 ul li input[type="submit"]:hover {
            background: linear-gradient(to bottom, #2D77A2 5%, #337DA8 100%);
            background-color: #28739E;
        }
        .auto-style8 {
            max-width: 650px;
            background: #FAFAFA;
            padding: 30px;
            margin: 50px auto;
            box-shadow: 1px 1px 25px rgba(0, 0, 0, 0.35);
            border-radius: 10px;
            border: 6px solid #305A72;
            width: 100%;
        }
        .auto-style1 {
            width: 212px;
        }
        .auto-style2 {
            width: 319px;
        }
        .auto-style3 {
            width: 319px;
        }
        .auto-style5 {
            width: 215px;
        }
        .auto-style6 {
            width: 215px;
        }
        .auto-style7 {
            width: 57%;
            height: 182px;
        }
        .auto-style9 {
            width: 212px;
        }
        .auto-style10 {
            height: 25px;
        }
        .auto-style12 {
            height: 25px;
            width: 212px;
        }
        .auto-style13 {
            width: 215px;
            height: 33px;
        }
        .auto-style14 {
            width: 319px;
            height: 33px;
        }
        .auto-style15 {
            width: 212px;
            height: 33px;
        }
        .footer {
           text-align: center;
           padding: 10px;
           font-size: 20px;
           color: #fff;
           background-color: #2A88AD;
           position: fixed;
           bottom: 0;
           width: 100%;
       }

         nav {
           background-color: #2A88AD;
           color: #fff;
           padding: 10px;
           text-align: center;
       }
    </style>

</head>
<body style="width: 100%; height: 100%">

    	 <nav>
        <h2>BIENVENIDOS AL REGISTRO DE ESTUDIANTE</h2>
    </nav>



    <form id="form1" runat="server" class="auto-style8" aria-sort="none">
    
        <h1>REGISTRO DE ESTUDIANTES</h1><br />
        <table class="auto-style7" style="width: 100%;">
            <tr>
                <td class="auto-style13">Cedula</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="field-style"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR" Width="135px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Nombre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtnombre" runat="server" CssClass="field-style"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" Width="134px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Apellido</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="field-style"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnLimpiar" runat="server" Text="LIMPIAR" Width="134px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Acudiente</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="field-style"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" Width="134px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Telefono</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="field-style"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="ACUDIENTE" Width="136px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
                    <asp:TextBox ID="txtbuscar" runat="server" Width="425px" CssClass="field-full"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnbuscar" runat="server" Text="BUSCAR" Width="137px" BackColor="#CCCCFF" BorderColor="Black" />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="SALIR" Width="137px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
        </table>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="642px">
      <Columns>
          <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
          <asp:BoundField DataField="nombre" HeaderText="nombre" />
          <asp:BoundField DataField="apellido" HeaderText="apellido" />
          <asp:BoundField DataField="acudiante" HeaderText="acudiante" />
          <asp:BoundField DataField="telefono" HeaderText="telefono" />
      </Columns>
             <PagerStyle BackColor="#CC99FF" BorderColor="#FF66FF" ForeColor="#FFCCFF" />
  </asp:GridView>
    
    </form>
    
	 <div class="footer">
        Joana Sanchez, Universidad Tecnológica de Panamá, Desarrollo de Software VIII, Examen Trimestral
    </div>
</body>
</html>
