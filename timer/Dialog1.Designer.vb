<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STAPH
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
        Me.staph1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'staph1
        '
        Me.staph1.Location = New System.Drawing.Point(12, 12)
        Me.staph1.Name = "staph1"
        Me.staph1.ReadOnly = True
        Me.staph1.Size = New System.Drawing.Size(389, 20)
        Me.staph1.TabIndex = 1
        Me.staph1.Text = "TIMER STOP"
        Me.staph1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'STAPH
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 54)
        Me.Controls.Add(Me.staph1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "STAPH"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOP"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents staph1 As System.Windows.Forms.TextBox

End Class
