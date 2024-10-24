'Imports System.Data.SqlClient
'Imports System.Net
'Imports System.IO
'Imports System.Drawing
'Imports System.Net.Http

'Public Class MainApp
'    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Me.CenterToScreen()
'        OpenConnection()
'        MsgBox("Conexión establecida correctamente")
'        GetArticulos()
'    End Sub

'    Public Sub GetArticulos()
'        Try
'            ' Assuming the URL field is named "ImageUrl" in the "Articulos" table
'            Dim query As String = "SELECT *, url FROM Articulos"
'            Dim adapter As New SqlDataAdapter(query, Connection)
'            Dim dataSet As New DataSet()
'            adapter.Fill(dataSet, "Articulos")
'            dataArticulos.DataSource = dataSet.Tables("Articulos")
'            If dataSet.Tables("Articulos").Rows.Count > 0 Then
'                Dim imageUrl As String = dataSet.Tables("Articulos").Rows(5)("url").ToString()
'                If Not String.IsNullOrEmpty(imageUrl) Then
'                    LoadImageIntoPictureBox(imageUrl)
'                Else
'                    MessageBox.Show("No image URL provided for the article.")
'                End If
'            End If
'        Catch ex As Exception
'            MsgBox("Error al obtener los artículos: " & ex.Message)
'        End Try
'    End Sub

'    Public Sub LoadImageIntoPictureBox(ByVal url As String)
'        Try
'            Dim image As Image = DownloadImageFromUrl(url)
'            image = ResizeImage(image, pictureBoxArticulo.Width, pictureBoxArticulo.Height)
'            pictureBoxArticulo.Image = image
'        Catch ex As Exception
'            MessageBox.Show("Error loading image: " & ex.Message)
'        End Try
'    End Sub

'    Private Function ResizeImage(ByVal img As Image, ByVal width As Integer, ByVal height As Integer) As Image
'        Dim bmp As New Bitmap(width, height)
'        Using g As Graphics = Graphics.FromImage(bmp)
'            g.DrawImage(img, 0, 0, width, height)
'        End Using
'        Return bmp
'    End Function

'    ' Function to download the image from URL
'    Private Function DownloadImageFromUrl(ByVal url As String) As Image
'        Dim image As Image = Nothing
'        Try
'            Dim webClient As New WebClient()
'            Using stream As Stream = webClient.OpenRead(url)
'                image = Image.FromStream(stream)
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error downloading image: " & ex.Message)
'        End Try
'        Return image
'    End Function


'End Class
