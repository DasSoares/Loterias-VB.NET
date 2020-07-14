Imports MetroFramework.Controls

Public Class Form1

#Region " Form "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtQdeDezenas.Focus()
        Randomize()
        Me.radMegaSena.Checked = True
        If Now.Hour >= 18 Then Me.chkTemas.Checked = True
    End Sub
#End Region

#Region " Controles "
    Private Sub txtQdeApostas_TextChanged(sender As Object, e As EventArgs) Handles txtQdeApostas.TextChanged
        Me.txtQdeApostas.Refresh()
    End Sub

    Private Sub txtQdeDezenas_TextChanged(sender As Object, e As EventArgs) Handles txtQdeDezenas.TextChanged
        Me.txtQdeDezenas.Refresh()
    End Sub

    Private Sub txtQdeTotal_TextChanged(sender As Object, e As EventArgs) Handles txtQdeTotal.TextChanged
        Me.txtQdeTotal.Refresh()
    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged
        Me.txtResultado.Refresh()
    End Sub

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
            AlteraCores(Me, MetroFramework.MetroColorStyle.Green)
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radLotoMania_CheckedChanged(sender As Object, e As EventArgs) Handles radLotoMania.CheckedChanged
        If Me.radLotoMania.Checked = True Then
            Me.txtQdeDezenas.Text = "50"
            Me.txtQdeTotal.Text = "100"
            AlteraCores(Me, MetroFramework.MetroColorStyle.Orange)
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radLotofacil_CheckedChanged(sender As Object, e As EventArgs) Handles radLotofacil.CheckedChanged
        If Me.radLotofacil.Checked = True Then
            Me.txtQdeDezenas.Text = "15"
            Me.txtQdeTotal.Text = "25"
            AlteraCores(Me, MetroFramework.MetroColorStyle.Pink)
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub radQuina_CheckedChanged(sender As Object, e As EventArgs) Handles radQuina.CheckedChanged
        If Me.radQuina.Checked = True Then
            Me.txtQdeDezenas.Text = "5"
            Me.txtQdeTotal.Text = "80"
            AlteraCores(Me, MetroFramework.MetroColorStyle.Purple)
        Else
            Me.txtQdeDezenas.Text = ""
            Me.txtQdeTotal.Text = ""
        End If
    End Sub

    Private Sub chkTemas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTemas.CheckedChanged
        If Me.chkTemas.Checked = False Then
            Me.Theme = MetroFramework.MetroThemeStyle.Light
        Else
            Me.chkTemas.Text = "TEMA DARK"
            Me.Theme = MetroFramework.MetroThemeStyle.Dark
        End If

        AlteraTema(Me)

        Me.Refresh()
    End Sub

    Private Sub btnProcessar_Click(sender As Object, e As EventArgs) Handles btnProcessar.Click
        With New Threading.Thread(Sub()

                                      Me.Invoke(Sub()

                                                    Sorteio()
                                                End Sub)
                                  End Sub)
            .Start()
        End With
    End Sub
#End Region

#Region " Funções "
    Private Sub Sorteio()
        Dim qdeApostas As Integer = Val(Me.txtQdeApostas.Text)
        Dim qdeDezenas As Integer = Val(Me.txtQdeDezenas.Text)
        Dim qdeTotal As Integer = Val(Me.txtQdeTotal.Text)
        'Dim apostas(qdeTotal) As String

        Me.txtResultado.Text = ""

        If qdeApostas > 10 Then
            Me.txtQdeApostas.Text = "10"
            qdeApostas = 10
        End If

        For i As Integer = 1 To qdeApostas
            Dim aposta As String = ""

            For j As Integer = 1 To qdeDezenas
                While True
                    'numlist.Add(GetRandom(i, qdeTotal))
                    Dim dezena As String = "00" & GetRandom(i, qdeTotal + 1).ToString()
                    'Dim dezena As String = "00" & Rnd() * qdeTotal

                    dezena = dezena.Substring(dezena.Length - 2)

                    If aposta.IndexOf(dezena) < 0 Then
                        If aposta.Length > 0 Then aposta &= "-"

                        aposta &= dezena
                        Exit While
                    End If

                    Application.DoEvents()
                End While
            Next

            Dim dezenas() As String = aposta.Split("-")
            Dim valores As New List(Of Integer)

            For k As Integer = 0 To dezenas.Count - 1
                Dim s As String = dezenas(k)
                If s = "00" Then s = "100"
                valores.Add(Val(s))
            Next

            valores.Sort()
            aposta = ""
            Dim total As Integer = 0

            For k As Integer = 0 To valores.Count - 1
                Dim s As String = "00" & valores(k).ToString
                s = s.Substring(s.Length - 2)
                If aposta.Length > 0 Then aposta &= " "
                aposta &= "[" & s & "] "
                total = valores.Count
            Next

            'apostas(i) = aposta
            If Me.txtResultado.Text.Trim.Length > 0 Then Me.txtResultado.Text &= vbCrLf & vbCrLf
            Me.txtResultado.Text &= aposta
            Me.lblqdeRegistros.Text = total.ToString
        Next
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' fazendo o Gerador static, preservamos a mesma instância
        ' assim não precisamos criar novas instância com a mesma semente 
        ' entre as chamadas
        Static Gerador As System.Random = New System.Random()
        Return Gerador.Next(Min, Max)
    End Function
#End Region

#Region " Tema & Cor "
    Private Sub AlteraTema(sender As Object)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Theme = Me.Theme
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraTema(obj)
            End If
        Next
    End Sub

    Private Sub AlteraCores(sender As Object, cor As MetroFramework.MetroColorStyle)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Style = cor
                Me.Style = cor
                Me.txtResultado.UseCustomBackColor = False
                Me.txtResultado.UseStyleColors = Me.Style
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraCores(obj, cor)
            End If
        Next

        Me.Refresh()
    End Sub

    Private Function TipoObjeto(ByRef controle As Object) As Boolean
        Dim b As Boolean = False

        If TypeOf controle Is MetroFramework.Controls.MetroButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroCheckBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroComboBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroContextMenu Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDataGridHelper Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDateTime Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroGrid Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLabel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLink Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroListView Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroPanel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressSpinner Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroRadioButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroScrollBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabControl Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabPage Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTextBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTile Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroToggle Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTrackBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroUserControl Then b = True

        Return b
    End Function
#End Region

End Class
