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
        btnGo = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        lblGender = New Label()
        txtGender = New TextBox()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(147, 205)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(188, 86)
        btnGo.TabIndex = 0
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(147, 37)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(188, 27)
        txtFirstName.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(45, 40)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(80, 20)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(147, 83)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(188, 27)
        txtLastName.TabIndex = 3
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(45, 86)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(79, 20)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(45, 133)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(57, 20)
        lblGender.TabIndex = 5
        lblGender.Text = "Gender"
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(147, 130)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(188, 27)
        txtGender.TabIndex = 6
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Tinker", "Tailor", "Soldier", "Sailor"})
        lstOccupation.Location = New Point(469, 69)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(138, 244)
        lstOccupation.TabIndex = 7
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(469, 37)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(85, 20)
        lblOccupation.TabIndex = 8
        lblOccupation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(txtGender)
        Controls.Add(lblGender)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label

End Class
