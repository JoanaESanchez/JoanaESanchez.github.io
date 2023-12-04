<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Acudiente.aspx.vb" Inherits="ExamenSemestral_JoanaSanchez.Acudiente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
.form-style-6{
	font: 95% Arial, Helvetica, sans-serif;
	max-width: 400px;
	margin: 10px auto;
	padding: 16px;
	background: #F7F7F7;
}
.form-style-6 h1{
	background: #43D1AF;
	padding: 20px 0;
	font-size: 140%;
	font-weight: 300;
	text-align: center;
	color: #fff;
	margin: -16px -16px 16px -16px;
}
.form-style-6 input[type="text"],
.form-style-6 input[type="date"],
.form-style-6 input[type="datetime"],
.form-style-6 input[type="email"],
.form-style-6 input[type="number"],
.form-style-6 input[type="search"],
.form-style-6 input[type="time"],
.form-style-6 input[type="url"],
.form-style-6 textarea,
.form-style-6 select 
{
	-webkit-transition: all 0.30s ease-in-out;
	-moz-transition: all 0.30s ease-in-out;
	-ms-transition: all 0.30s ease-in-out;
	-o-transition: all 0.30s ease-in-out;
	outline: none;
	box-sizing: border-box;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	width: 100%;
	background: #fff;
	margin-bottom: 4%;
	border: 1px solid #ccc;
	padding: 3%;
	color: #555;
	font: 95% Arial, Helvetica, sans-serif;
}
.form-style-6 input[type="text"]:focus,
.form-style-6 input[type="date"]:focus,
.form-style-6 input[type="datetime"]:focus,
.form-style-6 input[type="email"]:focus,
.form-style-6 input[type="number"]:focus,
.form-style-6 input[type="search"]:focus,
.form-style-6 input[type="time"]:focus,
.form-style-6 input[type="url"]:focus,
.form-style-6 textarea:focus,
.form-style-6 select:focus
{
	box-shadow: 0 0 5px #43D1AF;
	padding: 3%;
	border: 1px solid #43D1AF;
}

.form-style-6 input[type="submit"],
.form-style-6 input[type="button"]{
	box-sizing: border-box;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	width: 100%;
	padding: 3%;
	background: #43D1AF;
	border-bottom: 2px solid #30C29E;
	border-top-style: none;
	border-right-style: none;
	border-left-style: none;	
	color: #fff;
}
.form-style-6 input[type="submit"]:hover,
.form-style-6 input[type="button"]:hover{
	background: #2EBC99;
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
<body>

		 <nav>
        <h2>BIENVENIDOS AL REGISTRO DEL ACUDIENTE</h2>
    </nav>

    <form id="form1" runat="server" class="form-style-6">
        <h1>CONTACTO DEL ACUDIENTE</h1>
        <asp:Label ID="Label1" runat="server" Text="NOMBRE COMPLETO DEL ACUDIENTE"></asp:Label>
        <asp:TextBox ID="txtNombreacu" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="CORREO ELECTRÓNICO"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label3" runat="server" Text="LUGAR DE TRABAJO "></asp:Label>
        <asp:TextBox ID="txtDetalles" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="GUARDAR" />
        <asp:Button ID="Button2" runat="server" Text="REGRESAR" />
</form>

	 <div class="footer">
    Joana Sanchez, Universidad Tecnológica de Panamá, Desarrollo de Software VIII, Examen Trimestral
</div>

</body>
</html>
