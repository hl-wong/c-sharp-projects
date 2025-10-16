<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtTemperature = New TextBox()
        btnCheck = New Button()
        SuspendLayout()
        ' 
        ' txtTemperature
        ' 
        txtTemperature.Location = New Point(296, 100)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(200, 27)
        txtTemperature.TabIndex = 0
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(296, 163)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(200, 107)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check Temperature"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCheck)
        Controls.Add(txtTemperature)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnCheck As Button

End Class
