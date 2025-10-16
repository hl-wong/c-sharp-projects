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
        lblExamScore = New Label()
        txtExamScore = New TextBox()
        btnGrade = New Button()
        SuspendLayout()
        ' 
        ' lblExamScore
        ' 
        lblExamScore.AutoSize = True
        lblExamScore.Location = New Point(104, 76)
        lblExamScore.Name = "lblExamScore"
        lblExamScore.Size = New Size(193, 20)
        lblExamScore.TabIndex = 0
        lblExamScore.Text = "Enter the examination score"
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(317, 73)
        txtExamScore.MaxLength = 3
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(213, 27)
        txtExamScore.TabIndex = 1
        ' 
        ' btnGrade
        ' 
        btnGrade.Location = New Point(317, 144)
        btnGrade.Name = "btnGrade"
        btnGrade.Size = New Size(213, 72)
        btnGrade.TabIndex = 2
        btnGrade.Text = "Get Grade"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGrade)
        Controls.Add(txtExamScore)
        Controls.Add(lblExamScore)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGrade As Button

End Class
