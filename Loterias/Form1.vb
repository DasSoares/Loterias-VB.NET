Imports MetroFramework

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtQdeDezenas.Focus()
    End Sub

    Private Sub btnProcessar_Click(sender As Object, e As EventArgs) Handles btnProcessar.Click
        'ReiniciaForm(e, e)


        Dim qdeApostas As Integer = Val(Me.txtQdeApostas.Text)
        Dim qdeDezenas As Integer = Val(Me.txtQdeDezenas.Text)
        Dim qdeTotal As Integer = Val(Me.txtQdeTotal.Text)
        Dim numero(qdeTotal) As Integer
        Dim dezena As String = ""

        Me.txtResultado.Text = ""

        If qdeApostas > 10 Then
            Me.txtQdeApostas.Text = "10"
            qdeApostas = 10
        End If

        For i As Integer = 1 To qdeApostas
            Dim jogos As String = ""

            For j As Integer = 1 To qdeDezenas
                While True
                    dezena = "00" & GetRandom(i, qdeTotal).ToString
                    dezena = dezena.Substring(dezena.Length - 2)

                    If jogos.IndexOf(dezena) < 0 Then
                        Exit While
                    End If

                    Application.DoEvents()
                End While

                If jogos.Length > 0 Then jogos &= " "
                jogos &= "[ " & dezena & " ] "
            Next

            If Me.txtResultado.Text.Trim.Length > 0 Then Me.txtResultado.Text &= vbCrLf
            Me.txtResultado.Text &= jogos
        Next
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' fazendo o Gerador static, preservamos a mesma instância
        ' assim não precisamos criar novas instância com a mesma semente 
        ' entre as chamadas
        Static Gerador As System.Random = New System.Random()
        Return Gerador.Next(Min, Max)
    End Function

    Private Sub chkSelecionarJogo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionarJogo.CheckedChanged
        If Me.chkSelecionarJogo.Checked = True Then
            Me.txtQdeDezenas.Enabled = False
            Me.txtQdeTotal.Enabled = False
        Else
            Me.txtQdeDezenas.Enabled = True
            Me.txtQdeTotal.Enabled = True
        End If
    End Sub

    Private Sub radMegaSena_CheckedChanged(sender As Object, e As EventArgs) Handles radMegaSena.CheckedChanged
        If Me.radMegaSena.Checked = True Then
            Me.txtQdeDezenas.Text = "6"
            Me.txtQdeTotal.Text = "60"
            CorComponentes(MetroFramework.MetroColorStyle.Green)
            Me.Refresh()
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radLotoMania_CheckedChanged(sender As Object, e As EventArgs) Handles radLotoMania.CheckedChanged
        If Me.radLotoMania.Checked = True Then
            Me.txtQdeDezenas.Text = "50"
            Me.txtQdeTotal.Text = "100"
            CorComponentes(MetroFramework.MetroColorStyle.Orange)
            Me.Refresh()
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radLotofacil_CheckedChanged(sender As Object, e As EventArgs) Handles radLotofacil.CheckedChanged
        If Me.radLotofacil.Checked = True Then
            Me.txtQdeDezenas.Text = "15"
            Me.txtQdeTotal.Text = "25"
            CorComponentes(MetroFramework.MetroColorStyle.Red)
            Me.Refresh()
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radQuina_CheckedChanged(sender As Object, e As EventArgs) Handles radQuina.CheckedChanged
        If Me.radQuina.Checked = True Then
            Me.txtQdeDezenas.Text = "5"
            Me.txtQdeTotal.Text = "80"
            CorComponentes(MetroFramework.MetroColorStyle.Blue)
            Me.Refresh()
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub ReiniciaForm(sender As System.Object, e As System.EventArgs)
        'Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub CorComponentes(cor As MetroFramework.MetroColorStyle)
        Dim estilo As New MetroFramework.Components.MetroStyleManager

        For Each obj As Object In Me.Controls
            Try
                obj.Style = cor
                Me.Style = cor
                obj.Refresh()
            Catch ex As Exception

            End Try
        Next

        Me.Refresh()
    End Sub

    Private Sub chkTemas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTemas.CheckedChanged
        If Me.chkTemas.Checked = True Then
            Me.chkTemas.Text = "TEMA LIGHT"
            Me.Theme = MetroFramework.MetroThemeStyle.Light

            For Each obj As Object In Me.Controls
                Try
                    obj.Theme = MetroThemeStyle.Light
                    obj.Refresh()
                Catch ex As Exception

                End Try
            Next

        Else
            Me.chkTemas.Text = "TEMA DARK"
            Me.Theme = MetroFramework.MetroThemeStyle.Dark

            For Each obj As Object In Me.Controls
                Try
                    obj.Theme = MetroThemeStyle.Dark
                    obj.Refresh()
                Catch ex As Exception

                End Try
            Next
        End If

        Me.Refresh()
    End Sub
End Class
