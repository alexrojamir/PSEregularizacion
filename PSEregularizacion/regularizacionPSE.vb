Imports System.IO
Imports System.Net
Imports System.Text
Public Class regularizacionPSE
    Dim ruta = ""
    Dim token = ""
    Dim ruc As String = ""
    Dim razonSocial As String = ""
    Dim path As String = ""
    Dim serieboleta As String = ""
    Dim seriefactura As String = ""
    Public datos As New Entidades
    Public dat As New Datos
    Private Sub regularizacionPSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dat.CargarDatos(datos)
        Nuevo()
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Nuevo()
    End Sub
    Private Sub btExplorar_Click(sender As Object, e As EventArgs) Handles btExplorar.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Selecciona una carpeta"
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim carpetaSeleccionada As String = folderBrowserDialog.SelectedPath
            path = carpetaSeleccionada
            txRuta.Text = path
        End If
    End Sub
    Private Sub btRegularizar_Click(sender As Object, e As EventArgs) Handles btRegularizar.Click
        Procesar()
    End Sub
    Sub Nuevo()
        ruta = datos.url
        token = datos.token
        ruc = datos.ruc
        razonSocial = datos.rzsocial
        path = datos.path
        serieboleta = datos.serieboleta
        seriefactura = datos.seriefactura

        txEmpresa.Text = ruc & " - " & razonSocial
        txRuta.Text = path
        txSerie.Text = ""
        txNumero.Text = ""
        txRespuesta.Text = ""
        cbComprobante.Text = "Seleccione"
        cbComprobante.Select()
    End Sub
    Sub Procesar()
        Try
            If cbComprobante.Text = "Seleccione" Or IsNumeric(txNumero.Text) = False Or txSerie.Text = "" Then
                MessageBox.Show("Llene los campos correctamente")
            Else
                Dim sr = New StreamReader(path & "\" & ruc & "-" & txSerie.Text & txNumero.Text & ".txt") ''''LA RUTA DE TU TXT AQUI
                Dim txt_sincodificar = sr.ReadToEnd()
                Dim txt_byte = Encoding.Default.GetBytes(txt_sincodificar)
                Dim txt_utf8 = Encoding.UTF8.GetString(txt_byte)
                sr.Dispose()

                Dim txt_de_respuesta = sendTxt(ruta, token, txt_utf8)
                txRespuesta.Text = txt_de_respuesta
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
            Nuevo()
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

    Private Sub cbComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbComprobante.SelectedIndexChanged
        Dim serie As String = ""
        If cbComprobante.Text = "Seleccione" Then
            serie = ""
            txSerie.Text = serie
        Else
            If cbComprobante.Text = "BOLETA" Then
                serie = serieboleta
                txSerie.Text = serie
            Else
                serie = seriefactura
                txSerie.Text = serie
            End If
        End If
    End Sub
End Class
