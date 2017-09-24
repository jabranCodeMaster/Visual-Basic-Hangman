<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangMan
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
        Me.lblChar1 = New System.Windows.Forms.Label()
        Me.lblChar2 = New System.Windows.Forms.Label()
        Me.lblChar3 = New System.Windows.Forms.Label()
        Me.lblChar4 = New System.Windows.Forms.Label()
        Me.lblChar5 = New System.Windows.Forms.Label()
        Me.lblChar6 = New System.Windows.Forms.Label()
        Me.lblChar7 = New System.Windows.Forms.Label()
        Me.lblChar8 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox0 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChar1
        '
        Me.lblChar1.AutoSize = True
        Me.lblChar1.Location = New System.Drawing.Point(61, 373)
        Me.lblChar1.Name = "lblChar1"
        Me.lblChar1.Size = New System.Drawing.Size(25, 13)
        Me.lblChar1.TabIndex = 0
        Me.lblChar1.Text = "___"
        '
        'lblChar2
        '
        Me.lblChar2.AutoSize = True
        Me.lblChar2.Location = New System.Drawing.Point(92, 373)
        Me.lblChar2.Name = "lblChar2"
        Me.lblChar2.Size = New System.Drawing.Size(25, 13)
        Me.lblChar2.TabIndex = 1
        Me.lblChar2.Text = "___"
        '
        'lblChar3
        '
        Me.lblChar3.AutoSize = True
        Me.lblChar3.Location = New System.Drawing.Point(123, 373)
        Me.lblChar3.Name = "lblChar3"
        Me.lblChar3.Size = New System.Drawing.Size(25, 13)
        Me.lblChar3.TabIndex = 2
        Me.lblChar3.Text = "___"
        '
        'lblChar4
        '
        Me.lblChar4.AutoSize = True
        Me.lblChar4.Location = New System.Drawing.Point(154, 373)
        Me.lblChar4.Name = "lblChar4"
        Me.lblChar4.Size = New System.Drawing.Size(25, 13)
        Me.lblChar4.TabIndex = 3
        Me.lblChar4.Text = "___"
        '
        'lblChar5
        '
        Me.lblChar5.AutoSize = True
        Me.lblChar5.Location = New System.Drawing.Point(185, 373)
        Me.lblChar5.Name = "lblChar5"
        Me.lblChar5.Size = New System.Drawing.Size(25, 13)
        Me.lblChar5.TabIndex = 4
        Me.lblChar5.Text = "___"
        '
        'lblChar6
        '
        Me.lblChar6.AutoSize = True
        Me.lblChar6.Location = New System.Drawing.Point(211, 373)
        Me.lblChar6.Name = "lblChar6"
        Me.lblChar6.Size = New System.Drawing.Size(25, 13)
        Me.lblChar6.TabIndex = 5
        Me.lblChar6.Text = "___"
        '
        'lblChar7
        '
        Me.lblChar7.AutoSize = True
        Me.lblChar7.Location = New System.Drawing.Point(242, 373)
        Me.lblChar7.Name = "lblChar7"
        Me.lblChar7.Size = New System.Drawing.Size(25, 13)
        Me.lblChar7.TabIndex = 6
        Me.lblChar7.Text = "___"
        '
        'lblChar8
        '
        Me.lblChar8.AutoSize = True
        Me.lblChar8.Location = New System.Drawing.Point(273, 373)
        Me.lblChar8.Name = "lblChar8"
        Me.lblChar8.Size = New System.Drawing.Size(25, 13)
        Me.lblChar8.TabIndex = 7
        Me.lblChar8.Text = "___"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.ForestGreen
        Me.btnStart.Location = New System.Drawing.Point(11, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(199, 91)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(311, 296)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(233, 20)
        Me.txtEnter.TabIndex = 9
        Me.txtEnter.Text = "Enter a letter"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(311, 322)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(233, 61)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HangMan.My.Resources.Resources.hangman1
        Me.PictureBox1.Location = New System.Drawing.Point(699, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox0
        '
        Me.PictureBox0.Image = Global.HangMan.My.Resources.Resources.hangman0
        Me.PictureBox0.Location = New System.Drawing.Point(550, 13)
        Me.PictureBox0.Name = "PictureBox0"
        Me.PictureBox0.Size = New System.Drawing.Size(351, 371)
        Me.PictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox0.TabIndex = 11
        Me.PictureBox0.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Label9"
        '
        'HangMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(926, 395)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox0)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblChar8)
        Me.Controls.Add(Me.lblChar7)
        Me.Controls.Add(Me.lblChar6)
        Me.Controls.Add(Me.lblChar5)
        Me.Controls.Add(Me.lblChar4)
        Me.Controls.Add(Me.lblChar3)
        Me.Controls.Add(Me.lblChar2)
        Me.Controls.Add(Me.lblChar1)
        Me.Name = "HangMan"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChar1 As System.Windows.Forms.Label
    Friend WithEvents lblChar2 As System.Windows.Forms.Label
    Friend WithEvents lblChar3 As System.Windows.Forms.Label
    Friend WithEvents lblChar4 As System.Windows.Forms.Label
    Friend WithEvents lblChar5 As System.Windows.Forms.Label
    Friend WithEvents lblChar6 As System.Windows.Forms.Label
    Friend WithEvents lblChar7 As System.Windows.Forms.Label
    Friend WithEvents lblChar8 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents PictureBox0 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
