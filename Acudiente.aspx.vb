Imports MySql.Data.MySqlClient

Public Class Acudiente
    Inherits System.Web.UI.Page
    Dim connectionString As String = "Server=localhost;Database=Matricula;User ID=root;Password=Joana0401*;"
    Dim conexion As New MySqlConnection(connectionString)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Validar campos (puedes personalizar según tus necesidades)
            If String.IsNullOrWhiteSpace(txtNombreacu.Text) Or String.IsNullOrWhiteSpace(txtCorreo.Text) Then
                MostrarAlerta("Por favor, complete los campos obligatorios.")
                Return
            End If

            ' Abrir la conexión
            conexion.Open()

            ' Obtener los valores de los campos del formulario
            Dim NombreA As String = txtNombreacu.Text
            Dim Correo As String = txtCorreo.Text
            Dim Descripcion As String = txtDetalles.Text

            ' Consulta SQL para insertar los datos en la tabla Acudiente
            Dim consulta As String = "INSERT INTO Acudiente (NombreA, Correo, Descripcion) VALUES (@NombreA, @Correo, @Descripcion)"

            ' Crear un comando con la consulta y la conexión
            Using comando As New MySqlCommand(consulta, conexion)
                ' Asignar parámetros con sus respectivos valores
                comando.Parameters.AddWithValue("@NombreA", NombreA)
                comando.Parameters.AddWithValue("@Correo", Correo)
                comando.Parameters.AddWithValue("@Descripcion", Descripcion)

                ' Ejecutar la consulta
                comando.ExecuteNonQuery()
            End Using

            ' Notificar al usuario que la información se ha guardado correctamente
            MostrarAlerta("Registro agregado correctamente.")
        Catch ex As MySqlException
            ' Manejar excepciones específicas de MySQL
            MostrarAlerta($"Error de MySQL: {ex.Message}")
        Catch ex As Exception
            ' Manejar otras excepciones
            MostrarAlerta($"Error: {ex.Message}")
        Finally
            ' Cerrar la conexión después de su uso
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub MostrarAlerta(mensaje As String)
        ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('{mensaje}');", True)
    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Estudiantes.aspx")
    End Sub
End Class