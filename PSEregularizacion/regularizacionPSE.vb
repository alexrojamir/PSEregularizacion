Imports System.IO
Imports System.Net
Imports System.Text
Public Class regularizacionPSE
    Dim ruta = "https://api.pse.pe/api/v1/d13207229716459e92c01e70e340423dbd923c72b11c4d3faddd3231fab8e3e8"
    Dim token = "eyJhbGciOiJIUzI1NiJ9.ImQ2ZDJkN2I0MTg3NDRlNzM4NzIxMDQyOTljY2I2YzlkZDZjNGZlYTI1NTk0NDFhYjg1NjkzYTJiNTgxOWNiY2Ii.2xH6xsAZ3A8GNjHeIGp8oMMbsJQQovDceDbFgGAn7do"
    Dim ruc As String = "20306230612"
    Dim razonSocial As String = "LTC INVERSIONES S.A."
    Dim rutaArchivo As String = ""
    Private Sub regularizacionPSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Limpiar()
    End Sub
    Private Sub btExplorar_Click(sender As Object, e As EventArgs) Handles btExplorar.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Selecciona una carpeta"
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim carpetaSeleccionada As String = folderBrowserDialog.SelectedPath
            rutaArchivo = carpetaSeleccionada
            txRuta.Text = rutaArchivo
        End If
    End Sub
    Private Sub btRegularizar_Click(sender As Object, e As EventArgs) Handles btRegularizar.Click
        Procesar()
    End Sub
    Sub Limpiar()
        txEmpresa.Text = ruc & " - " & razonSocial
        txRuta.Text = "C:\VensysEfact\105\comprobantes"
        cbComprobante.Text = "Seleccione"
        txSerie.Text = ""
        txNumero.Text = ""
        txRespuesta.Text = ""
    End Sub
    Sub Procesar()
        Try
            Dim sr = New StreamReader(rutaArchivo & "\" & ruc & "-" & txSerie.Text & txNumero.Text & ".txt") ''''LA RUTA DE TU TXT AQUI
            Dim txt_sincodificar = sr.ReadToEnd()
            Dim txt_byte = Encoding.Default.GetBytes(txt_sincodificar)
            Dim txt_utf8 = Encoding.UTF8.GetString(txt_byte)
            sr.Dispose()

            Dim txt_de_respuesta = sendTxt(ruta, token, txt_utf8)
            txRespuesta.Text = txt_de_respuesta
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
            Limpiar()
        End Try
    End Sub
    Function sendTxt(ruta As String, token As String, json As String) As String
        Using wc As New WebClient
            Try
                wc.Headers.Add(HttpRequestHeader.ContentType, "text/plain")
                wc.Headers.Add(HttpRequestHeader.Authorization, "Token token=" & token)
                Dim respuesta = wc.UploadString(ruta, "POST", json)
                Return respuesta
            Catch x As WebException
                Return New StreamReader(x.Response.GetResponseStream).ReadToEnd
            End Try
        End Using
    End Function
    hola


End Class
