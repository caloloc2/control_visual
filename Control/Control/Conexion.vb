Public Class Conexion
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" And TextBox1.Text <> "" Then
            My.Settings.puertocom = ComboBox1.Text
            My.Settings.baudrate = TextBox1.Text
            My.Settings.Save()

            Me.Dispose()
            Me.Close()
        Else
            MsgBox("Debe especificar los dos campos obligatoriamente.")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" And TextBox1.Text <> "" Then
            Test()
        Else
            MsgBox("Debe especificar los dos campos obligatoriamente.")
        End If
    End Sub

    Private Sub Conexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        If My.Settings.puertocom <> "" Then
            ComboBox1.Text = My.Settings.puertocom
        End If

        TextBox1.Text = My.Settings.baudrate
    End Sub

    Private Sub Test()
        Try
            If Not Puerto_Serie_Test.IsOpen Then
                With Puerto_Serie_Test
                    .PortName = ComboBox1.Text
                    .BaudRate = TextBox1.Text
                    .StopBits = IO.Ports.StopBits.One
                    .DataBits = 8
                    .Open()

                    MsgBox("Se ha conectado correctamente")

                    .Close()
                End With
            Else
                MsgBox("El puerto seleccionado se encuentra ocupado, libérelo y vuelva a intentar.")
            End If

        Catch ex As Exception
            MsgBox("Se ha producido un error en la conexión. Verifique los datos e intente nuevamente.")
        End Try

    End Sub

End Class