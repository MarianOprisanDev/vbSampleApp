<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.TextBoxHistory = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxHistory
        '
        Me.TextBoxHistory.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxHistory.Multiline = True
        Me.TextBoxHistory.Name = "TextBoxHistory"
        Me.TextBoxHistory.ReadOnly = True
        Me.TextBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxHistory.Size = New System.Drawing.Size(287, 174)
        Me.TextBoxHistory.TabIndex = 0
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 172)
        Me.Controls.Add(Me.TextBoxHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxHistory As TextBox
End Class
