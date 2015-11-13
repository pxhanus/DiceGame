<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRisk = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblOutcome = New System.Windows.Forms.Label()
        Me.picDice1 = New System.Windows.Forms.PictureBox()
        Me.picDice2 = New System.Windows.Forms.PictureBox()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRisk
        '
        Me.lblRisk.AutoSize = True
        Me.lblRisk.Location = New System.Drawing.Point(12, 22)
        Me.lblRisk.Name = "lblRisk"
        Me.lblRisk.Size = New System.Drawing.Size(97, 13)
        Me.lblRisk.TabIndex = 0
        Me.lblRisk.Text = "Enter points to risk:"
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(115, 19)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(59, 20)
        Me.txtRisk.TabIndex = 1
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(187, 17)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblOutcome
        '
        Me.lblOutcome.AutoSize = True
        Me.lblOutcome.Location = New System.Drawing.Point(184, 102)
        Me.lblOutcome.Name = "lblOutcome"
        Me.lblOutcome.Size = New System.Drawing.Size(0, 13)
        Me.lblOutcome.TabIndex = 3
        '
        'picDice1
        '
        Me.picDice1.Location = New System.Drawing.Point(12, 68)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(80, 80)
        Me.picDice1.TabIndex = 4
        Me.picDice1.TabStop = False
        '
        'picDice2
        '
        Me.picDice2.Location = New System.Drawing.Point(98, 68)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(80, 80)
        Me.picDice2.TabIndex = 5
        Me.picDice2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 173)
        Me.Controls.Add(Me.picDice2)
        Me.Controls.Add(Me.picDice1)
        Me.Controls.Add(Me.lblOutcome)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblRisk)
        Me.Name = "Form1"
        Me.Text = "Dice Game"
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRisk As System.Windows.Forms.Label
    Friend WithEvents txtRisk As System.Windows.Forms.TextBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblOutcome As System.Windows.Forms.Label
    Friend WithEvents picDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice2 As System.Windows.Forms.PictureBox

End Class
