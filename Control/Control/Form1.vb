Public Class Form1
    Dim conectado As Boolean = False

    Private Sub ConexiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexiónToolStripMenuItem.Click
        Conexion.ShowDialog()
    End Sub

    Private Sub Conectar()
        Try
            If My.Settings.puertocom <> "" And My.Settings.baudrate <> "" Then
                If Not conectado Then
                    If Not Puerto_Serie.IsOpen Then
                        With Puerto_Serie
                            .PortName = My.Settings.puertocom
                            .BaudRate = My.Settings.baudrate
                            .StopBits = IO.Ports.StopBits.One
                            .DataBits = 8
                            .Open()
                            Estado_Conexion.Text = "Conectado al dispositivo"
                            ConectarAlDispositivoToolStripMenuItem.Text = "Desconectar del dispositivo"
                            conectado = True
                            Timer.Enabled = True
                        End With
                    End If
                Else
                    If Puerto_Serie.IsOpen Then
                        Puerto_Serie.Close()
                        Estado_Conexion.Text = "Desconectado"
                        ConectarAlDispositivoToolStripMenuItem.Text = "Conectar al dispositivo"
                        conectado = False
                        Timer.Enabled = False
                    End If
                End If
            Else
                MsgBox("No se ha configurado los parámetros para la conexión al dispositivo")
                Conexion.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido un error al realizar la conexión al dispositivo")
        End Try
    End Sub

    Private Sub ConectarAlDispositivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarAlDispositivoToolStripMenuItem.Click
        Conectar()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Puerto_Serie.IsOpen Then
            Dim datos As String = Puerto_Serie.ReadLine
            If datos <> "" Then
                Analisis(datos)
            End If
        End If
    End Sub

    Private Sub Analisis(valor As String)
        Try
            Dim separa() As String = valor.Split("/")
            Dim campos() As String = separa(2).Split("*")

            Select Case Trim(separa(0))
                Case "1" ' XBEE 1
                    Z1_T.Text = campos(0)
                    Z1_H.Text = campos(1)
                    Z1_F.Text = campos(2)
                    Z1_B.Text = campos(3)
                Case "2" ' XBEE 2
                    Z2_T.Text = campos(0)
                    Z2_H.Text = campos(1)
                    Z2_F.Text = campos(2)
                    Z2_B.Text = campos(3)
                Case "3" ' XBEE 3                    
                    Z3_T.Text = campos(0)
                    Z3_H.Text = campos(1)
                    Z3_F.Text = campos(2)
                    Z3_B.Text = campos(3)
            End Select
        Catch ex As Exception

        End Try

        'Try
        '    If IsNumeric(campos(0)) And IsNumeric(campos(2)) Then
        '        Dim temp1 As Double = CDbl(campos(0))
        '        Dim temp2 As Double = CDbl(campos(2))
        '        Dim promedio As Double = (temp1 + temp2) / 2

        '        Dim temp_seteo As Double = CDbl(S_T.Text)

        '        If promedio > temp_seteo Then
        '            A_M.BackColor = Color.Red
        '            A_V.BackColor = Color.Orange
        '        Else
        '            A_M.BackColor = Color.Gray
        '            A_V.BackColor = Color.Gray
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Puerto_Serie.IsOpen Then
            Puerto_Serie.Close()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If Puerto_Serie.IsOpen Then
            Puerto_Serie.Close()
        End If
        Application.Exit()
    End Sub
End Class

