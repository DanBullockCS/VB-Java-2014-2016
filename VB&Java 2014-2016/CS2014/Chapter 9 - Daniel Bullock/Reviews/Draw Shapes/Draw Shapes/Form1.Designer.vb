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
        Me.btnDrawShapes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDrawShapes
        '
        Me.btnDrawShapes.Location = New System.Drawing.Point(12, 12)
        Me.btnDrawShapes.Name = "btnDrawShapes"
        Me.btnDrawShapes.Size = New System.Drawing.Size(79, 23)
        Me.btnDrawShapes.TabIndex = 0
        Me.btnDrawShapes.Text = "Draw Shapes"
        Me.btnDrawShapes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 138)
        Me.Controls.Add(Me.btnDrawShapes)
        Me.Name = "Form1"
        Me.Text = "Draw Shapes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDrawShapes As System.Windows.Forms.Button

End Class
