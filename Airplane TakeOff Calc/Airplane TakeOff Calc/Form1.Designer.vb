<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirplaneTakeOff
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAirCraft = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Airplane"
        '
        'lstAirCraft
        '
        Me.lstAirCraft.BackColor = System.Drawing.Color.Gray
        Me.lstAirCraft.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAirCraft.FormattingEnabled = True
        Me.lstAirCraft.Location = New System.Drawing.Point(41, 106)
        Me.lstAirCraft.Name = "lstAirCraft"
        Me.lstAirCraft.Size = New System.Drawing.Size(196, 186)
        Me.lstAirCraft.TabIndex = 1
        Me.lstAirCraft.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Bottom
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(294, 93)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(434, 219)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom
        '
        'frmAirplaneTakeOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(CInt(Screen.PrimaryScreen.WorkingArea.Width * 0.9), CInt(Screen.PrimaryScreen.WorkingArea.Height * 0.9))
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstAirCraft)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAirplaneTakeOff"
        Me.Text = "Airplane TakeOff Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstAirCraft As System.Windows.Forms.ListBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class