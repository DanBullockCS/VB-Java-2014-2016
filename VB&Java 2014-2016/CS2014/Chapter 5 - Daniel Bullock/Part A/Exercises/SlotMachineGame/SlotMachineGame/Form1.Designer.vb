﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(63, 38)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(0, 25)
        Me.lblNum1.TabIndex = 0
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(147, 38)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(0, 25)
        Me.lblNum2.TabIndex = 1
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(233, 38)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(0, 25)
        Me.lblNum3.TabIndex = 2
        '
        'lblTokens
        '
        Me.lblTokens.AutoSize = True
        Me.lblTokens.Location = New System.Drawing.Point(173, 103)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(0, 13)
        Me.lblTokens.TabIndex = 3
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Location = New System.Drawing.Point(65, 103)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(93, 13)
        Me.lblStatement.TabIndex = 4
        Me.lblStatement.Text = "Tokens you have:"
        '
        'btnPull
        '
        Me.btnPull.Location = New System.Drawing.Point(140, 148)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(72, 21)
        Me.btnPull.TabIndex = 5
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 181)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form1"
        Me.Text = "Slot Machine Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents lblTokens As System.Windows.Forms.Label
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnPull As System.Windows.Forms.Button

End Class
