Imports System.Net

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxIP.Items.Clear()
        cbxIP.Items.AddRange(Dns.GetHostAddresses(Dns.GetHostName))
        Dim ip As String
        Dim ipcerto As String
        For i = 1 To cbxIP.Items.Count - 1
            ip = cbxIP.Items(i).ToString
            If ip.Contains("10.20") Or ip.Contains("10.10") Then
                ipcerto = ip.ToString()
                For j = 1 To 3
                    ipcerto = ipcerto.Substring(0, ipcerto.Length - 1)
                Next
                MessageBox.Show(ipcerto)
            End If
        Next
    End Sub
End Class
