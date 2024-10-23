﻿Imports System.IO
Imports System.Net.Http

Public Class UserControl1
    ' This code goes in your Form1 class

    ' Function to resize the image
    Private Function ResizeImage(ByVal img As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim bmp As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(img, 0, 0, width, height)
        End Using
        Return bmp
    End Function

    ' Function to download the image from URL
    Private Function DownloadImageFromUrl(ByVal url As String) As Image
        Dim image As Image = Nothing
        Try
            Dim webClient As New HttpClient()
            Using stream As Stream = webClient.GetStreamAsync(url).Result
                image = Image.FromStream(stream)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error downloading image: " & ex.Message)
        End Try
        Return image
    End Function


    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' URL of the image
        Dim url As String = "https://cdn-icons-png.flaticon.com/512/5621/5621813.png"

        ' Download the image from the URL
        Dim originalImage As Image = DownloadImageFromUrl(url)

        If originalImage IsNot Nothing Then
            ' Resize the image (for example, 50x50)
            Dim resizedImage As Image = ResizeImage(originalImage, 96, 96)

            ' Display the resized image in the PictureBox
            PictureBox1.Image = resizedImage
        End If
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

End Class