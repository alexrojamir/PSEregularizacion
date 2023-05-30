Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Datos
    Public Function CargarDatos(ByRef param As Entidades)
        Try
            Dim rutadatos As String = AppDomain.CurrentDomain.BaseDirectory & "Datos.xml"
            If IO.File.Exists(rutadatos) = True Then
                Dim ods As New DataSet
                ods.ReadXml(rutadatos)
                If DesencriptarDatos_DataSet(ods) = False Then
                    Return False
                End If
                If ods.Tables.Count > 0 Then
                    With param
                        .url = CStr(ods.Tables(0).Rows(0)("url"))
                        .token = CStr(ods.Tables(0).Rows(0)("token"))
                        .ruc = CStr(ods.Tables(0).Rows(0)("ruc"))
                        .rzsocial = CStr(ods.Tables(0).Rows(0)("razsocial"))
                        .path = CStr(ods.Tables(0).Rows(0)("path"))
                        .serieboleta = CStr(ods.Tables(0).Rows(0)("serieboleta"))
                        .seriefactura = CStr(ods.Tables(0).Rows(0)("seriefactura"))
                    End With
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el archivo de configuracion")
        End Try
    End Function
    Private Function DesencriptarDatos_DataSet(ByRef dt As DataSet) As Boolean
        If dt IsNot Nothing Then
            If dt.Tables.Count >= 1 Then
                For cTabla As Integer = 0 To dt.Tables.Count - 1
                    If dt.Tables(cTabla) IsNot Nothing Then
                        If dt.Tables(cTabla).Rows.Count >= 1 Then
                            For cColm As Integer = 0 To dt.Tables(cTabla).Columns.Count - 1
                                Dim textoNuevo As String
                                If Fstr_Desencriptar(dt.Tables(cTabla).Rows(0)(cColm).ToString()) Is Nothing Then
                                    Return False
                                Else
                                    textoNuevo = Fstr_Desencriptar(dt.Tables(cTabla).Rows(0)(cColm).ToString())
                                End If
                                dt.Tables(cTabla).Rows(0)(cColm) = textoNuevo
                            Next
                        End If
                    End If
                Next
            End If
        End If
        Return True
    End Function
    Private Function Fstr_Desencriptar(ByVal CadenaCifrada As String) As String
        Dim sHeyHey As String = "Tç1 S.A. 2009"
        Dim CadenaDescifrada As String
        Dim TripleDES As New TripleDESCryptoServiceProvider
        Try
            Dim encryptedBytes As Byte() = Convert.FromBase64String(CadenaCifrada)
            Dim ms As New MemoryStream
            TripleDES.Key = TruncateHash(sHeyHey, TripleDES.KeySize \ 8)
            TripleDES.IV = TruncateHash("", TripleDES.BlockSize \ 8)
            Dim decStream As New CryptoStream(ms, TripleDES.CreateDecryptor(), CryptoStreamMode.Write)
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()
            CadenaDescifrada = Encoding.Unicode.GetString(ms.ToArray)
            Return CadenaDescifrada
        Catch ex As Exception
            MessageBox.Show("Error al cargar la encriptacion")
            Return Nothing
        End Try
    End Function
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider
        Dim keyBytes As Byte() = Encoding.Unicode.GetBytes(key)
        Dim hash As Byte() = sha1.ComputeHash(keyBytes)
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
End Class
