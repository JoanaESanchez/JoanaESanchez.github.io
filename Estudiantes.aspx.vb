
Imports MySql.Data.MySqlClient


Partial Public Class Estudiantes
    Inherits System.Web.UI.Page

    Dim connectionString As String = "Server=localhost;Database=Matricula;User ID=root;Password=Joana0401*;"
    Dim conexion As New MySqlConnection(connectionString)

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Validar campos
            If Not ValidarCampos() Then
                Return
            End If

            ' Abrir la conexión
            conexion.Open()

            ' Obtener los valores de los campos del formulario
            Dim cedula As String = TextBox2.Text
            Dim nombre As String = txtnombre.Text
            Dim apellido As String = txtTelefono.Text
            Dim acudiente As String = TextBox3.Text
            Dim telefono As String = TextBox4.Text

            ' Consulta SQL para insertar los datos en la tabla Registro
            Dim consulta As String = "INSERT INTO Registro (Cedula, nombre, apellido, acudiante, telefono) VALUES (@Cedula, @nombre, @apellido, @acudiante, @telefono)"

            ' Crear un comando con la consulta y la conexión
            Using comando As New MySqlCommand(consulta, conexion)
                ' Asignar parámetros con sus respectivos valores
                comando.Parameters.AddWithValue("@Cedula", cedula)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@acudiante", acudiente)
                comando.Parameters.AddWithValue("@telefono", telefono)

                ' Ejecutar la consulta
                comando.ExecuteNonQuery()
            End Using

            ' Notificar al usuario que la información se ha guardado correctamente
            MostrarAlerta("Registro agregado correctamente.")
        Catch ex As Exception
            ' Manejar excepciones
            MostrarAlerta($"Error: {ex.Message}")
        Finally
            ' Cerrar la conexión después de su uso
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            ' Abrir la conexión
            conexion.Open()

            ' Obtener los valores de los campos del formulario
            Dim cedula As String = TextBox2.Text
            Dim nombre As String = txtnombre.Text
            Dim apellido As String = txtTelefono.Text
            Dim acudiente As String = TextBox3.Text
            Dim telefono As String = TextBox4.Text

            ' Consulta SQL para actualizar los datos en la tabla Registro
            Dim consulta As String = "UPDATE Registro SET nombre = @nombre, apellido = @apellido, acudiante = @acudiante, telefono = @telefono WHERE cedula = @cedula"

            ' Crear un comando con la consulta y la conexión
            Using comando As New MySqlCommand(consulta, conexion)
                ' Asignar parámetros con sus respectivos valores
                comando.Parameters.AddWithValue("@cedula", cedula)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@acudiante", acudiente)
                comando.Parameters.AddWithValue("@telefono", telefono)

                ' Ejecutar la consulta
                comando.ExecuteNonQuery()
            End Using

            ' Notificar al usuario que la información se ha actualizado correctamente
            MostrarAlerta("Registro actualizado correctamente.")
        Catch ex As Exception
            ' Manejar excepciones
            MostrarAlerta($"Error: {ex.Message}")
        Finally
            ' Cerrar la conexión después de su uso
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Dim indiceSeleccionado As Integer = GridView1.SelectedIndex

        ' Verificar si se ha seleccionado una fila
        If indiceSeleccionado >= 0 AndAlso indiceSeleccionado < GridView1.Rows.Count Then
            ' Obtener los valores de las celdas de la fila seleccionada
            Dim cedula As String = GridView1.Rows(indiceSeleccionado).Cells(0).Text ' Asumiendo que la cédula está en la primera columna
            Dim nombre As String = GridView1.Rows(indiceSeleccionado).Cells(1).Text
            Dim apellido As String = GridView1.Rows(indiceSeleccionado).Cells(2).Text
            Dim acudiente As String = GridView1.Rows(indiceSeleccionado).Cells(3).Text
            Dim telefono As String = GridView1.Rows(indiceSeleccionado).Cells(4).Text

            ' Asignar los valores a los controles de entrada para su edición
            TextBox2.Text = cedula
            txtnombre.Text = nombre
            txtTelefono.Text = apellido
            TextBox3.Text = acudiente
            TextBox4.Text = telefono
        End If

    End Sub

    Private Sub LimpiarCampos()
        TextBox2.Text = String.Empty
        txtnombre.Text = String.Empty
        txtTelefono.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Puedes agregar aquí la lógica de validación según tus requisitos
        Return Not String.IsNullOrWhiteSpace(TextBox2.Text) And Not String.IsNullOrWhiteSpace(txtnombre.Text)
    End Function

    Private Sub MostrarAlerta(mensaje As String)
        ' Función para mostrar mensajes de alerta
        ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('{mensaje}');", True)
    End Sub

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            ' Abrir la conexión
            conexion.Open()

            ' Obtener el valor del campo de búsqueda
            Dim valorBusqueda As String = txtbuscar.Text

            ' Consulta SQL para buscar en la tabla Registro
            Dim consulta As String = "SELECT * FROM Registro WHERE Cedula = @valorBusqueda OR nombre = @valorBusqueda OR apellido = @valorBusqueda OR acudiante = @valorBusqueda OR telefono = @valorBusqueda"

            ' Crear un comando con la consulta y la conexión
            Using comando As New MySqlCommand(consulta, conexion)
                ' Asignar parámetro con el valor de búsqueda
                comando.Parameters.AddWithValue("@valorBusqueda", valorBusqueda)

                ' Crear un adaptador y un conjunto de datos para obtener los resultados de la consulta
                Using adaptador As New MySqlDataAdapter(comando)
                    Dim dataSet As New DataSet()
                    adaptador.Fill(dataSet, "Registro")

                    ' Asignar los datos al GridView
                    GridView1.DataSource = dataSet.Tables("Registro")
                    GridView1.DataBind()
                End Using
            End Using
        Catch ex As MySqlException
            ' Manejar excepciones específicas de MySQL
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error de MySQL: {ex.Message}');", True)
        Catch ex As Exception
            ' Manejar otras excepciones
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error: {ex.Message}');", True)
        Finally
            ' Cerrar la conexión después de su uso
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub ActualizarGridView()
        ' Lógica para actualizar la GridView después de la inserción o búsqueda
        ' Puedes implementar la lógica de consulta y asignación de datos a la GridView aquí
        ' Por ejemplo, puedes llamar a la función que obtiene todos los registros y los asigna a la GridView
        ObtenerYMostrarRegistros()
    End Sub

    ' Función para obtener y mostrar todos los registros en la GridView
    Private Sub ObtenerYMostrarRegistros()
        Try
            ' Realizar una consulta para obtener todos los datos de la tabla Registro
            Dim consulta As String = "SELECT * FROM Registro"

            Using adaptador As New MySqlDataAdapter(consulta, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Registro")

                ' Asignar los datos al GridView
                GridView1.DataSource = dataSet.Tables("Registro")
                GridView1.DataBind()
            End Using
        Catch ex As MySqlException
            ' Manejar excepciones específicas de MySQL
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error de MySQL: {ex.Message}');", True)
        Catch ex As Exception
            ' Manejar otras excepciones
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error: {ex.Message}');", True)
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ' Abrir la conexión
            conexion.Open()

            ' Obtener el valor del campo de búsqueda
            Dim cedulaEliminar As String = txtbuscar.Text

            ' Consulta SQL para eliminar el registro con la cédula proporcionada
            Dim consultaEliminar As String = "DELETE FROM Registro WHERE Cedula = @cedulaEliminar"

            ' Crear un comando con la consulta de eliminación y la conexión
            Using comandoEliminar As New MySqlCommand(consultaEliminar, conexion)
                ' Asignar parámetro con la cédula a eliminar
                comandoEliminar.Parameters.AddWithValue("@cedulaEliminar", cedulaEliminar)

                ' Ejecutar la consulta de eliminación
                comandoEliminar.ExecuteNonQuery()
            End Using

            ' Notificar al usuario que el registro se ha eliminado correctamente
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Registro eliminado correctamente.');", True)

            ' Actualizar la GridView después de la eliminación
            ActualizarGridView()
        Catch ex As MySqlException
            ' Manejar excepciones específicas de MySQL
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error de MySQL: {ex.Message}');", True)
        Catch ex As Exception
            ' Manejar otras excepciones
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", $"alert('Error: {ex.Message}');", True)
        Finally
            ' Cerrar la conexión después de su uso
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Acudiente.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("LoginForm.aspx")
    End Sub

End Class
