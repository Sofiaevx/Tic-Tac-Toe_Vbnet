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
        Me.SuspendLayout()
        '
        'TopLeftBtn
        '
        Me.TopLeftBtn.BackColor = System.Drawing.Color.Black
        Me.TopLeftBtn.FlatAppearance.BorderSize = 0
        Me.TopLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TopLeftBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TopLeftBtn.Location = New System.Drawing.Point(12, 94)
        Me.TopLeftBtn.Name = "TopLeftBtn"
        Me.TopLeftBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TopLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.TopLeftBtn.TabIndex = 0
        Me.TopLeftBtn.TabStop = False
        Me.TopLeftBtn.Text = "X"
        Me.TopLeftBtn.UseVisualStyleBackColor = False
        '
        'MiddleTopBtn
        '
        Me.MiddleTopBtn.BackColor = System.Drawing.Color.Black
        Me.MiddleTopBtn.FlatAppearance.BorderSize = 0
        Me.MiddleTopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleTopBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleTopBtn.Location = New System.Drawing.Point(106, 94)
        Me.MiddleTopBtn.Name = "MiddleTopBtn"
        Me.MiddleTopBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleTopBtn.TabIndex = 1
        Me.MiddleTopBtn.TabStop = False
        Me.MiddleTopBtn.UseVisualStyleBackColor = False
        '
        'TopRightBtn
        '
        Me.TopRightBtn.BackColor = System.Drawing.Color.Black
        Me.TopRightBtn.FlatAppearance.BorderSize = 0
        Me.TopRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TopRightBtn.Location = New System.Drawing.Point(202, 94)
        Me.TopRightBtn.Name = "TopRightBtn"
        Me.TopRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.TopRightBtn.TabIndex = 2
        Me.TopRightBtn.TabStop = False
        Me.TopRightBtn.UseVisualStyleBackColor = False
        '
        'MiddleLeftBtn
        '
        Me.MiddleLeftBtn.BackColor = System.Drawing.Color.Black
        Me.MiddleLeftBtn.FlatAppearance.BorderSize = 0
        Me.MiddleLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleLeftBtn.Location = New System.Drawing.Point(12, 182)
        Me.MiddleLeftBtn.Name = "MiddleLeftBtn"
        Me.MiddleLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleLeftBtn.TabIndex = 3
        Me.MiddleLeftBtn.TabStop = False
        Me.MiddleLeftBtn.UseVisualStyleBackColor = False
        '
        'MiddleCenterBtn
        '
        Me.MiddleCenterBtn.BackColor = System.Drawing.Color.Black
        Me.MiddleCenterBtn.FlatAppearance.BorderSize = 0
        Me.MiddleCenterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleCenterBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleCenterBtn.Location = New System.Drawing.Point(106, 182)
        Me.MiddleCenterBtn.Name = "MiddleCenterBtn"
        Me.MiddleCenterBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleCenterBtn.TabIndex = 4
        Me.MiddleCenterBtn.TabStop = False
        Me.MiddleCenterBtn.UseVisualStyleBackColor = False
        '
        'MiddleRightBtn
        '
        Me.MiddleRightBtn.BackColor = System.Drawing.Color.Black
        Me.MiddleRightBtn.FlatAppearance.BorderSize = 0
        Me.MiddleRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleRightBtn.Location = New System.Drawing.Point(202, 182)
        Me.MiddleRightBtn.Name = "MiddleRightBtn"
        Me.MiddleRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleRightBtn.TabIndex = 5
        Me.MiddleRightBtn.TabStop = False
        Me.MiddleRightBtn.UseVisualStyleBackColor = False
        '
        'BottomRightBtn
        '
        Me.BottomRightBtn.BackColor = System.Drawing.Color.Black
        Me.BottomRightBtn.FlatAppearance.BorderSize = 0
        Me.BottomRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomRightBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BottomRightBtn.Location = New System.Drawing.Point(202, 270)
        Me.BottomRightBtn.Name = "BottomRightBtn"
        Me.BottomRightBtn.Size = New System.Drawing.Size(79, 82)
        Me.BottomRightBtn.TabIndex = 8
        Me.BottomRightBtn.TabStop = False
        Me.BottomRightBtn.UseVisualStyleBackColor = False
        '
        'MiddleBottomBtn
        '
        Me.MiddleBottomBtn.BackColor = System.Drawing.Color.Black
        Me.MiddleBottomBtn.FlatAppearance.BorderSize = 0
        Me.MiddleBottomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MiddleBottomBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MiddleBottomBtn.Location = New System.Drawing.Point(106, 270)
        Me.MiddleBottomBtn.Name = "MiddleBottomBtn"
        Me.MiddleBottomBtn.Size = New System.Drawing.Size(79, 82)
        Me.MiddleBottomBtn.TabIndex = 7
        Me.MiddleBottomBtn.TabStop = False
        Me.MiddleBottomBtn.UseVisualStyleBackColor = False
        '
        'BottomLeftBtn
        '
        Me.BottomLeftBtn.BackColor = System.Drawing.Color.Black
        Me.BottomLeftBtn.FlatAppearance.BorderSize = 0
        Me.BottomLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomLeftBtn.Font = New System.Drawing.Font("Snap ITC", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BottomLeftBtn.Location = New System.Drawing.Point(12, 270)
        Me.BottomLeftBtn.Name = "BottomLeftBtn"
        Me.BottomLeftBtn.Size = New System.Drawing.Size(79, 82)
        Me.BottomLeftBtn.TabIndex = 6
        Me.BottomLeftBtn.TabStop = False
        Me.BottomLeftBtn.UseVisualStyleBackColor = False
        '
        'Player1name
        '
        Me.Player1name.AutoSize = True
        Me.Player1name.BackColor = System.Drawing.Color.Black
        Me.Player1name.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player1name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Player1name.Location = New System.Drawing.Point(12, 44)
        Me.Player1name.Name = "Player1name"
        Me.Player1name.Size = New System.Drawing.Size(129, 22)
        Me.Player1name.TabIndex = 9
        Me.Player1name.Text = "Players name"
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Black
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HomeBtn.Location = New System.Drawing.Point(202, 358)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(79, 36)
        Me.HomeBtn.TabIndex = 11
        Me.HomeBtn.TabStop = False
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Black
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ResetBtn.Location = New System.Drawing.Point(12, 358)
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
        Me.Player2name.BackColor = System.Drawing.Color.Black
        Me.Player2name.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Player2name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Player2name.Location = New System.Drawing.Point(152, 44)
        Me.Player2name.Name = "Player2name"
        Me.Player2name.Size = New System.Drawing.Size(129, 22)
        Me.Player2name.TabIndex = 13
        Me.Player2name.Text = "Players name"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(293, 400)
        Me.ControlBox = False
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
End Class
