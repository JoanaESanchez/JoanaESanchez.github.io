Imports MySql.Data.MySqlClient
Public Class LoginForm
    Inherits System.Web.UI.Page

    Dim connectionString As String = "Server=localhost;Database=Matricula;User ID=root;Password=Joana0401*;"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = txtUsuario.Text
        Dim clave As String = txtClave.Text

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(usuario) Or String.IsNullOrEmpty(clave) Then
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Por favor, ingrese usuario y clave.');", True)
            Return
        End If

        ' Intentar realizar la conexión y la inserción en la base de datos
        Try
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()

                ' Consulta SQL para insertar los datos en la tabla usuarios (debes adaptarla según tu estructura)
                Dim consulta As String = "INSERT INTO usuarios (nombre_usuario, clave) VALUES (@usuario, @clave)"
                Using comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@usuario", usuario)
                    comando.Parameters.AddWithValue("@clave", clave)

                    ' Ejecutar la consulta
                    comando.ExecuteNonQuery()

                    ' Notificar al usuario que la información se ha guardado correctamente
                    ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Datos guardados correctamente en la base de datos.');", True)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier error que pueda ocurrir durante la conexión o la inserción
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error: {ex.Message}');", True)
        End Try
        Response.Redirect("Estudiantes.aspx")
    End Sub
End Class
