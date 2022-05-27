<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.Player2name = New System.Windows.Forms.TextBox()
        Me.Player1name = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player2name
        '
        Me.Player2name.BackColor = System.Drawing.SystemColors.ControlText
        Me.Player2name.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player2name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Player2name.Location = New System.Drawing.Point(27, 353)
        Me.Player2name.MaxLength = 10
        Me.Player2name.Name = "Player2name"
        Me.Player2name.PlaceholderText = "Enter player 2 name:"
        Me.Player2name.Size = New System.Drawing.Size(223, 26)
        Me.Player2name.TabIndex = 16
        Me.Player2name.TabStop = False
        '
        'Player1name
        '
        Me.Player1name.BackColor = System.Drawing.SystemColors.ControlText
        Me.Player1name.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player1name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Player1name.Location = New System.Drawing.Point(27, 307)
        Me.Player1name.MaxLength = 10
        Me.Player1name.Name = "Player1name"
        Me.Player1name.PlaceholderText = "Enter player 1 name:"
        Me.Player1name.Size = New System.Drawing.Size(223, 26)
        Me.Player1name.TabIndex = 17
        Me.Player1name.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tic Tac Toe"
        '
        'PlayBtn
        '
        Me.PlayBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PlayBtn.FlatAppearance.BorderSize = 0
        Me.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayBtn.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Location = New System.Drawing.Point(100, 396)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(79, 36)
        Me.PlayBtn.TabIndex = 20
        Me.PlayBtn.TabStop = False
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.UseVisualStyleBackColor = False
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 452)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Player1name)
        Me.Controls.Add(Me.Player2name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tictactoe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player2name As TextBox
    Friend WithEvents Player1name As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayBtn As Button
End Class
