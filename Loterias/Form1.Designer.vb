<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm
    Dim isTemaDark As Boolean = False
    Dim isStyle As Boolean = False

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.chkTemas = New MetroFramework.Controls.MetroCheckBox()
        Me.radLotoMania = New MetroFramework.Controls.MetroRadioButton()
        Me.radLotofacil = New MetroFramework.Controls.MetroRadioButton()
        Me.radQuina = New MetroFramework.Controls.MetroRadioButton()
        Me.radMegaSena = New MetroFramework.Controls.MetroRadioButton()
        Me.btnProcessar = New MetroFramework.Controls.MetroButton()
        Me.txtQdeDezenas = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtQdeApostas = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtQdeTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.chkSelecionarJogo = New MetroFramework.Controls.MetroCheckBox()
        Me.txtResultado = New MetroFramework.Controls.MetroTextBox()
        Me.lblqdeRegistros = New MetroFramework.Controls.MetroLabel()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Loterias.My.Resources.Resources.icons8_opportunity_32
        Me.picLogo.Location = New System.Drawing.Point(17, 21)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(32, 32)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.chkTemas)
        Me.MetroPanel1.Controls.Add(Me.radLotoMania)
        Me.MetroPanel1.Controls.Add(Me.radLotofacil)
        Me.MetroPanel1.Controls.Add(Me.radQuina)
        Me.MetroPanel1.Controls.Add(Me.radMegaSena)
        Me.MetroPanel1.Controls.Add(Me.btnProcessar)
        Me.MetroPanel1.Controls.Add(Me.txtQdeDezenas)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.txtQdeApostas)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtQdeTotal)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(10, 74)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(151, 320)
        Me.MetroPanel1.TabIndex = 17
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'chkTemas
        '
        Me.chkTemas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTemas.BackColor = System.Drawing.Color.Transparent
        Me.chkTemas.CausesValidation = False
        Me.chkTemas.Location = New System.Drawing.Point(17, 300)
        Me.chkTemas.Name = "chkTemas"
        Me.chkTemas.Size = New System.Drawing.Size(117, 15)
        Me.chkTemas.TabIndex = 16
        Me.chkTemas.Text = "TEMA DARK"
        Me.chkTemas.UseSelectable = True
        '
        'radLotoMania
        '
        Me.radLotoMania.AutoSize = True
        Me.radLotoMania.BackColor = System.Drawing.Color.Transparent
        Me.radLotoMania.Location = New System.Drawing.Point(17, 29)
        Me.radLotoMania.Name = "radLotoMania"
        Me.radLotoMania.Size = New System.Drawing.Size(95, 15)
        Me.radLotoMania.TabIndex = 10
        Me.radLotoMania.Text = "LOTO-MANIA"
        Me.radLotoMania.UseSelectable = True
        '
        'radLotofacil
        '
        Me.radLotofacil.AutoSize = True
        Me.radLotofacil.BackColor = System.Drawing.Color.Transparent
        Me.radLotofacil.Location = New System.Drawing.Point(17, 50)
        Me.radLotofacil.Name = "radLotofacil"
        Me.radLotofacil.Size = New System.Drawing.Size(81, 15)
        Me.radLotofacil.TabIndex = 9
        Me.radLotofacil.Text = "LOTOFÁCIL"
        Me.radLotofacil.UseSelectable = True
        '
        'radQuina
        '
        Me.radQuina.AutoSize = True
        Me.radQuina.BackColor = System.Drawing.Color.Transparent
        Me.radQuina.Location = New System.Drawing.Point(17, 71)
        Me.radQuina.Name = "radQuina"
        Me.radQuina.Size = New System.Drawing.Size(60, 15)
        Me.radQuina.TabIndex = 8
        Me.radQuina.Text = "QUINA"
        Me.radQuina.UseSelectable = True
        '
        'radMegaSena
        '
        Me.radMegaSena.AutoSize = True
        Me.radMegaSena.BackColor = System.Drawing.Color.Transparent
        Me.radMegaSena.Location = New System.Drawing.Point(17, 8)
        Me.radMegaSena.Name = "radMegaSena"
        Me.radMegaSena.Size = New System.Drawing.Size(90, 15)
        Me.radMegaSena.TabIndex = 7
        Me.radMegaSena.Text = "MEGA-SENA"
        Me.radMegaSena.UseSelectable = True
        '
        'btnProcessar
        '
        Me.btnProcessar.Highlight = True
        Me.btnProcessar.Location = New System.Drawing.Point(17, 235)
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Size = New System.Drawing.Size(119, 40)
        Me.btnProcessar.TabIndex = 3
        Me.btnProcessar.Text = "PROCESSAR"
        Me.btnProcessar.UseSelectable = True
        '
        'txtQdeDezenas
        '
        '
        '
        '
        Me.txtQdeDezenas.CustomButton.Image = Nothing
        Me.txtQdeDezenas.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.txtQdeDezenas.CustomButton.Name = ""
        Me.txtQdeDezenas.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQdeDezenas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQdeDezenas.CustomButton.TabIndex = 1
        Me.txtQdeDezenas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQdeDezenas.CustomButton.UseSelectable = True
        Me.txtQdeDezenas.CustomButton.Visible = False
        Me.txtQdeDezenas.Lines = New String() {"50"}
        Me.txtQdeDezenas.Location = New System.Drawing.Point(17, 159)
        Me.txtQdeDezenas.MaxLength = 2
        Me.txtQdeDezenas.Name = "txtQdeDezenas"
        Me.txtQdeDezenas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQdeDezenas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQdeDezenas.SelectedText = ""
        Me.txtQdeDezenas.SelectionLength = 0
        Me.txtQdeDezenas.SelectionStart = 0
        Me.txtQdeDezenas.ShortcutsEnabled = True
        Me.txtQdeDezenas.ShowClearButton = True
        Me.txtQdeDezenas.Size = New System.Drawing.Size(119, 23)
        Me.txtQdeDezenas.TabIndex = 1
        Me.txtQdeDezenas.Text = "50"
        Me.txtQdeDezenas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQdeDezenas.UseSelectable = True
        Me.txtQdeDezenas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQdeDezenas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 143)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 15)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Qde Dezenas"
        '
        'txtQdeApostas
        '
        '
        '
        '
        Me.txtQdeApostas.CustomButton.Image = Nothing
        Me.txtQdeApostas.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.txtQdeApostas.CustomButton.Name = ""
        Me.txtQdeApostas.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQdeApostas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQdeApostas.CustomButton.TabIndex = 1
        Me.txtQdeApostas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQdeApostas.CustomButton.UseSelectable = True
        Me.txtQdeApostas.CustomButton.Visible = False
        Me.txtQdeApostas.Lines = New String() {"1"}
        Me.txtQdeApostas.Location = New System.Drawing.Point(17, 117)
        Me.txtQdeApostas.MaxLength = 2
        Me.txtQdeApostas.Name = "txtQdeApostas"
        Me.txtQdeApostas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQdeApostas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQdeApostas.SelectedText = ""
        Me.txtQdeApostas.SelectionLength = 0
        Me.txtQdeApostas.SelectionStart = 0
        Me.txtQdeApostas.ShortcutsEnabled = True
        Me.txtQdeApostas.ShowClearButton = True
        Me.txtQdeApostas.Size = New System.Drawing.Size(119, 23)
        Me.txtQdeApostas.TabIndex = 0
        Me.txtQdeApostas.Text = "1"
        Me.txtQdeApostas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQdeApostas.UseSelectable = True
        Me.txtQdeApostas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQdeApostas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 101)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(74, 15)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Qde Apostas"
        '
        'txtQdeTotal
        '
        '
        '
        '
        Me.txtQdeTotal.CustomButton.Image = Nothing
        Me.txtQdeTotal.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.txtQdeTotal.CustomButton.Name = ""
        Me.txtQdeTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQdeTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQdeTotal.CustomButton.TabIndex = 1
        Me.txtQdeTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQdeTotal.CustomButton.UseSelectable = True
        Me.txtQdeTotal.CustomButton.Visible = False
        Me.txtQdeTotal.Lines = New String() {"100"}
        Me.txtQdeTotal.Location = New System.Drawing.Point(17, 201)
        Me.txtQdeTotal.MaxLength = 3
        Me.txtQdeTotal.Name = "txtQdeTotal"
        Me.txtQdeTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQdeTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQdeTotal.SelectedText = ""
        Me.txtQdeTotal.SelectionLength = 0
        Me.txtQdeTotal.SelectionStart = 0
        Me.txtQdeTotal.ShortcutsEnabled = True
        Me.txtQdeTotal.ShowClearButton = True
        Me.txtQdeTotal.Size = New System.Drawing.Size(119, 23)
        Me.txtQdeTotal.TabIndex = 2
        Me.txtQdeTotal.Text = "100"
        Me.txtQdeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQdeTotal.UseSelectable = True
        Me.txtQdeTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQdeTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 185)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 15)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Qde Total"
        '
        'chkSelecionarJogo
        '
        Me.chkSelecionarJogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSelecionarJogo.AutoSize = True
        Me.chkSelecionarJogo.BackColor = System.Drawing.Color.Transparent
        Me.chkSelecionarJogo.Checked = True
        Me.chkSelecionarJogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelecionarJogo.Location = New System.Drawing.Point(10, 400)
        Me.chkSelecionarJogo.Name = "chkSelecionarJogo"
        Me.chkSelecionarJogo.Size = New System.Drawing.Size(156, 15)
        Me.chkSelecionarJogo.TabIndex = 15
        Me.chkSelecionarJogo.Text = "SELECIONAR POR JOGOS"
        Me.chkSelecionarJogo.UseSelectable = True
        '
        'txtResultado
        '
        Me.txtResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtResultado.CustomButton.Image = Nothing
        Me.txtResultado.CustomButton.Location = New System.Drawing.Point(183, 1)
        Me.txtResultado.CustomButton.Name = ""
        Me.txtResultado.CustomButton.Size = New System.Drawing.Size(319, 319)
        Me.txtResultado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResultado.CustomButton.TabIndex = 1
        Me.txtResultado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResultado.CustomButton.UseSelectable = True
        Me.txtResultado.CustomButton.Visible = False
        Me.txtResultado.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtResultado.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtResultado.Lines = New String(-1) {}
        Me.txtResultado.Location = New System.Drawing.Point(167, 74)
        Me.txtResultado.MaxLength = 100
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultado.SelectedText = ""
        Me.txtResultado.SelectionLength = 0
        Me.txtResultado.SelectionStart = 0
        Me.txtResultado.ShortcutsEnabled = True
        Me.txtResultado.ShowClearButton = True
        Me.txtResultado.Size = New System.Drawing.Size(503, 321)
        Me.txtResultado.TabIndex = 14
        Me.txtResultado.UseSelectable = True
        Me.txtResultado.UseStyleColors = True
        Me.txtResultado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResultado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblqdeRegistros
        '
        Me.lblqdeRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblqdeRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblqdeRegistros.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblqdeRegistros.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblqdeRegistros.Location = New System.Drawing.Point(596, 56)
        Me.lblqdeRegistros.Name = "lblqdeRegistros"
        Me.lblqdeRegistros.Size = New System.Drawing.Size(74, 15)
        Me.lblqdeRegistros.TabIndex = 11
        Me.lblqdeRegistros.Text = "0"
        Me.lblqdeRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(677, 423)
        Me.Controls.Add(Me.lblqdeRegistros)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.chkSelecionarJogo)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "Form1"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "     JOGOS ALEATÓRIOS"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents radLotoMania As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radLotofacil As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radQuina As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMegaSena As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnProcessar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtQdeDezenas As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtQdeApostas As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtQdeTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkTemas As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkSelecionarJogo As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtResultado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblqdeRegistros As MetroFramework.Controls.MetroLabel
End Class
