<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ExamenSemestral_JoanaSanchez.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script type="text/javascript">
        function imprimirTabla() {
            // Obtener los datos de la tabla desde el servidor
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ObtenerDatosTabla",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    // Crear una ventana emergente con los datos de la tabla
                    var ventanaImpresion = window.open('', '_blank');
                    ventanaImpresion.document.write('<html><head><title>Tabla Imprimible</title></head><body>');

                    // Agregar los datos de la tabla a la ventana emergente
                    ventanaImpresion.document.write('<table border="1">');
                    for (var i = 0; i < response.d.length; i++) {
                        ventanaImpresion.document.write('<tr>');
                        ventanaImpresion.document.write('<td>' + response.d[i].Cedula + '</td>');
                        ventanaImpresion.document.write('<td>' + response.d[i].Nombre + '</td>');
                        // Agregar más columnas según sea necesario
                        ventanaImpresion.document.write('</tr>');
                    }
                    ventanaImpresion.document.write('</table>');

                    ventanaImpresion.document.write('</body></html>');
                    ventanaImpresion.document.close();

                    // Omitir la impresión en la consola
                    // No hay necesidad de imprimir nada aquí
                },
                error: function (error) {
                    alert("Ocurrió un error al obtener los datos de la tabla.");
                }
            });
        }
    </script>
    <style>
        body {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            margin: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <button type="button" onclick="imprimirTabla()">Imprimir Tabla</button>
        </div>
    </form>
</body>
</html>
