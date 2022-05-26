<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopLeftBtn = New System.Windows.Forms.Button()
        Me.MiddleTopBtn = New System.Windows.Forms.Button()
        Me.TopRightBtn = New System.Windows.Forms.Button()
        Me.MiddleLeftBtn = New System.Windows.Forms.Button()
        Me.MiddleCenterBtn = New System.Windows.Forms.Button()
        Me.MiddleRightBtn = New System.Windows.Forms.Button()
        Me.BottomRightBtn = New System.Windows.Forms.Button()
        Me.MiddleBottomBtn = New System.Windows.Forms.Button()
        Me.BottomLeftBtn = New System.Windows.Forms.Button()
        Me.Player1name = New System.Windows.Forms.Label()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Player2name = New System.Windows.Forms.Label()
        Me.Playersturnlabel = New System.Windows.Forms.Label()
        Me.titlelabel = New System.Windows.Forms.Label()
        Me.p1score = New System.Windows.Forms.Label()
        Me.colon1label = New System.Windows.Forms.Label()
        Me.colon2label = New System.Windows.Forms.Label()
        Me.p2score = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TopLeftBtn
        '
        Me.TopLeftBtn.BackColor = System.Drawing.Color.White
        Me.TopLeftBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.TopLeftBtn.FlatAppearance.BorderSize = 0
        Me.TopLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TopLeftBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TopLeftBtn.Location = New System.Drawing.Point(14, 136)
        Me.TopLeftBtn.Name = "TopLeftBtn"
        Me.TopLeftBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TopLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.TopLeftBtn.TabIndex = 0
        Me.TopLeftBtn.TabStop = False
        Me.TopLeftBtn.UseVisualStyleBackColor = False
        '
        'MiddleTopBtn
        '
        Me.MiddleTopBtn.BackColor = System.Drawing.Color.White
        Me.MiddleTopBtn.FlatAppearance.BorderSize = 0
        Me.MiddleTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleTopBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleTopBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MiddleTopBtn.Location = New System.Drawing.Point(99, 136)
        Me.MiddleTopBtn.Name = "MiddleTopBtn"
        Me.MiddleTopBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleTopBtn.TabIndex = 1
        Me.MiddleTopBtn.TabStop = False
        Me.MiddleTopBtn.UseVisualStyleBackColor = False
        '
        'TopRightBtn
        '
        Me.TopRightBtn.BackColor = System.Drawing.Color.White
        Me.TopRightBtn.FlatAppearance.BorderSize = 0
        Me.TopRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TopRightBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TopRightBtn.Location = New System.Drawing.Point(184, 136)
        Me.TopRightBtn.Name = "TopRightBtn"
        Me.TopRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.TopRightBtn.TabIndex = 2
        Me.TopRightBtn.TabStop = False
        Me.TopRightBtn.UseVisualStyleBackColor = False
        '
        'MiddleLeftBtn
        '
        Me.MiddleLeftBtn.BackColor = System.Drawing.Color.White
        Me.MiddleLeftBtn.FlatAppearance.BorderSize = 0
        Me.MiddleLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleLeftBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MiddleLeftBtn.Location = New System.Drawing.Point(14, 224)
        Me.MiddleLeftBtn.Name = "MiddleLeftBtn"
        Me.MiddleLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleLeftBtn.TabIndex = 3
        Me.MiddleLeftBtn.TabStop = False
        Me.MiddleLeftBtn.UseVisualStyleBackColor = False
        '
        'MiddleCenterBtn
        '
        Me.MiddleCenterBtn.BackColor = System.Drawing.Color.White
        Me.MiddleCenterBtn.FlatAppearance.BorderSize = 0
        Me.MiddleCenterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleCenterBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleCenterBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MiddleCenterBtn.Location = New System.Drawing.Point(99, 224)
        Me.MiddleCenterBtn.Name = "MiddleCenterBtn"
        Me.MiddleCenterBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleCenterBtn.TabIndex = 4
        Me.MiddleCenterBtn.TabStop = False
        Me.MiddleCenterBtn.UseVisualStyleBackColor = False
        '
        'MiddleRightBtn
        '
        Me.MiddleRightBtn.BackColor = System.Drawing.Color.White
        Me.MiddleRightBtn.FlatAppearance.BorderSize = 0
        Me.MiddleRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleRightBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MiddleRightBtn.Location = New System.Drawing.Point(184, 224)
        Me.MiddleRightBtn.Name = "MiddleRightBtn"
        Me.MiddleRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleRightBtn.TabIndex = 5
        Me.MiddleRightBtn.TabStop = False
        Me.MiddleRightBtn.UseVisualStyleBackColor = False
        '
        'BottomRightBtn
        '
        Me.BottomRightBtn.BackColor = System.Drawing.Color.White
        Me.BottomRightBtn.FlatAppearance.BorderSize = 0
        Me.BottomRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BottomRightBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BottomRightBtn.Location = New System.Drawing.Point(184, 312)
        Me.BottomRightBtn.Name = "BottomRightBtn"
        Me.BottomRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.BottomRightBtn.TabIndex = 8
        Me.BottomRightBtn.TabStop = False
        Me.BottomRightBtn.UseVisualStyleBackColor = False
        '
        'MiddleBottomBtn
        '
        Me.MiddleBottomBtn.BackColor = System.Drawing.Color.White
        Me.MiddleBottomBtn.FlatAppearance.BorderSize = 0
        Me.MiddleBottomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleBottomBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleBottomBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MiddleBottomBtn.Location = New System.Drawing.Point(99, 312)
        Me.MiddleBottomBtn.Name = "MiddleBottomBtn"
        Me.MiddleBottomBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleBottomBtn.TabIndex = 7
        Me.MiddleBottomBtn.TabStop = False
        Me.MiddleBottomBtn.UseVisualStyleBackColor = False
        '
        'BottomLeftBtn
        '
        Me.BottomLeftBtn.BackColor = System.Drawing.Color.White
        Me.BottomLeftBtn.FlatAppearance.BorderSize = 0
        Me.BottomLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BottomLeftBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BottomLeftBtn.Location = New System.Drawing.Point(14, 312)
        Me.BottomLeftBtn.Name = "BottomLeftBtn"
        Me.BottomLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.BottomLeftBtn.TabIndex = 6
        Me.BottomLeftBtn.TabStop = False
        Me.BottomLeftBtn.UseVisualStyleBackColor = False
        '
        'Player1name
        '
        Me.Player1name.AutoSize = True
        Me.Player1name.BackColor = System.Drawing.Color.Transparent
        Me.Player1name.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player1name.ForeColor = System.Drawing.Color.White
        Me.Player1name.Location = New System.Drawing.Point(14, 107)
        Me.Player1name.Name = "Player1name"
        Me.Player1name.Size = New System.Drawing.Size(89, 16)
        Me.Player1name.TabIndex = 9
        Me.Player1name.Text = "Players name"
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.Location = New System.Drawing.Point(184, 404)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(79, 36)
        Me.HomeBtn.TabIndex = 11
        Me.HomeBtn.TabStop = False
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ResetBtn.Location = New System.Drawing.Point(21, 404)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(79, 36)
        Me.ResetBtn.TabIndex = 12
        Me.ResetBtn.TabStop = False
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Player2name
        '
        Me.Player2name.AutoSize = True
        Me.Player2name.BackColor = System.Drawing.Color.Transparent
        Me.Player2name.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player2name.ForeColor = System.Drawing.Color.White
        Me.Player2name.Location = New System.Drawing.Point(153, 107)
        Me.Player2name.Name = "Player2name"
        Me.Player2name.Size = New System.Drawing.Size(89, 16)
        Me.Player2name.TabIndex = 13
        Me.Player2name.Text = "Players name"
        '
        'Playersturnlabel
        '
        Me.Playersturnlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Playersturnlabel.BackColor = System.Drawing.Color.Black
        Me.Playersturnlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Playersturnlabel.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Playersturnlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Playersturnlabel.Location = New System.Drawing.Point(12, 57)
        Me.Playersturnlabel.Name = "Playersturnlabel"
        Me.Playersturnlabel.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.Playersturnlabel.Size = New System.Drawing.Size(251, 37)
        Me.Playersturnlabel.TabIndex = 14
        Me.Playersturnlabel.Text = "Player's Turn"
        Me.Playersturnlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'titlelabel
        '
        Me.titlelabel.AutoSize = True
        Me.titlelabel.BackColor = System.Drawing.Color.Transparent
        Me.titlelabel.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.titlelabel.ForeColor = System.Drawing.Color.White
        Me.titlelabel.Location = New System.Drawing.Point(63, 15)
        Me.titlelabel.Name = "titlelabel"
        Me.titlelabel.Size = New System.Drawing.Size(155, 28)
        Me.titlelabel.TabIndex = 15
        Me.titlelabel.Text = "tic tac toe"
        '
        'p1score
        '
        Me.p1score.AutoSize = True
        Me.p1score.BackColor = System.Drawing.Color.Transparent
        Me.p1score.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.p1score.ForeColor = System.Drawing.Color.Gold
        Me.p1score.Location = New System.Drawing.Point(110, 108)
        Me.p1score.Name = "p1score"
        Me.p1score.Size = New System.Drawing.Size(15, 16)
        Me.p1score.TabIndex = 16
        Me.p1score.Text = "0"
        '
        'colon1label
        '
        Me.colon1label.AutoSize = True
        Me.colon1label.BackColor = System.Drawing.Color.Transparent
        Me.colon1label.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.colon1label.ForeColor = System.Drawing.Color.White
        Me.colon1label.Location = New System.Drawing.Point(99, 107)
        Me.colon1label.Name = "colon1label"
        Me.colon1label.Size = New System.Drawing.Size(13, 18)
        Me.colon1label.TabIndex = 17
        Me.colon1label.Text = ":"
        '
        'colon2label
        '
        Me.colon2label.AutoSize = True
        Me.colon2label.BackColor = System.Drawing.Color.Transparent
        Me.colon2label.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.colon2label.ForeColor = System.Drawing.Color.White
        Me.colon2label.Location = New System.Drawing.Point(238, 107)
        Me.colon2label.Name = "colon2label"
        Me.colon2label.Size = New System.Drawing.Size(13, 18)
        Me.colon2label.TabIndex = 18
        Me.colon2label.Text = ":"
        '
        'p2score
        '
        Me.p2score.AutoSize = True
        Me.p2score.BackColor = System.Drawing.Color.Transparent
        Me.p2score.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.p2score.ForeColor = System.Drawing.Color.Gold
        Me.p2score.Location = New System.Drawing.Point(247, 108)
        Me.p2score.Name = "p2score"
        Me.p2score.Size = New System.Drawing.Size(15, 16)
        Me.p2score.TabIndex = 19
        Me.p2score.Text = "0"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(279, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.p2score)
        Me.Controls.Add(Me.colon2label)
        Me.Controls.Add(Me.colon1label)
        Me.Controls.Add(Me.p1score)
        Me.Controls.Add(Me.titlelabel)
        Me.Controls.Add(Me.Playersturnlabel)
        Me.Controls.Add(Me.Player2name)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.Player1name)
        Me.Controls.Add(Me.BottomRightBtn)
        Me.Controls.Add(Me.MiddleBottomBtn)
        Me.Controls.Add(Me.BottomLeftBtn)
        Me.Controls.Add(Me.MiddleRightBtn)
        Me.Controls.Add(Me.MiddleCenterBtn)
        Me.Controls.Add(Me.MiddleLeftBtn)
        Me.Controls.Add(Me.TopRightBtn)
        Me.Controls.Add(Me.MiddleTopBtn)
        Me.Controls.Add(Me.TopLeftBtn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TicTacToe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICTACTOE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopLeftBtn As Button
    Friend WithEvents MiddleTopBtn As Button
    Friend WithEvents TopRightBtn As Button
    Friend WithEvents MiddleLeftBtn As Button
    Friend WithEvents MiddleCenterBtn As Button
    Friend WithEvents MiddleRightBtn As Button
    Friend WithEvents BottomRightBtn As Button
    Friend WithEvents MiddleBottomBtn As Button
    Friend WithEvents BottomLeftBtn As Button
    Friend WithEvents Player1name As Label
    Friend WithEvents HomeBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Player2name As Label
    Friend WithEvents Playersturnlabel As Label
    Friend WithEvents titlelabel As Label
    Friend WithEvents p1score As Label
    Friend WithEvents colon1label As Label
    Friend WithEvents colon2label As Label
    Friend WithEvents p2score As Label
End Class
