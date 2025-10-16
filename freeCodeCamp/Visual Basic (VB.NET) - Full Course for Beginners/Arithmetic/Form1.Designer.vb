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
        lblNumber1 = New Label()
        txtNumber1 = New TextBox()
        lblNumber2 = New Label()
        txtNumber2 = New TextBox()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' lblNumber1
        ' 
        lblNumber1.AutoSize = True
        lblNumber1.Location = New Point(129, 75)
        lblNumber1.Name = "lblNumber1"
        lblNumber1.Size = New Size(75, 20)
        lblNumber1.TabIndex = 0
        lblNumber1.Text = "Number 1"
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(225, 72)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(180, 27)
        txtNumber1.TabIndex = 1
        ' 
        ' lblNumber2
        ' 
        lblNumber2.AutoSize = True
        lblNumber2.Location = New Point(129, 122)
        lblNumber2.Name = "lblNumber2"
        lblNumber2.Size = New Size(75, 20)
        lblNumber2.TabIndex = 2
        lblNumber2.Text = "Number 2"
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(225, 119)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(180, 27)
        txtNumber2.TabIndex = 3
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(225, 183)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(180, 66)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(txtNumber2)
        Controls.Add(lblNumber2)
        Controls.Add(txtNumber1)
        Controls.Add(lblNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumber1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnCalculate As Button

End Class
