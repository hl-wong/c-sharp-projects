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
        btnStart = New Button()
        btnRowWise = New Button()
        btnColumnWise = New Button()
        btnOutputAll = New Button()
        btnSearch = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(41, 31)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(148, 66)
        btnStart.TabIndex = 0
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRowWise
        ' 
        btnRowWise.Location = New Point(327, 31)
        btnRowWise.Name = "btnRowWise"
        btnRowWise.Size = New Size(264, 47)
        btnRowWise.TabIndex = 1
        btnRowWise.Text = "Display data items row wise"
        btnRowWise.UseVisualStyleBackColor = True
        ' 
        ' btnColumnWise
        ' 
        btnColumnWise.Location = New Point(327, 93)
        btnColumnWise.Name = "btnColumnWise"
        btnColumnWise.Size = New Size(264, 47)
        btnColumnWise.TabIndex = 2
        btnColumnWise.Text = "Display data items column wise"
        btnColumnWise.UseVisualStyleBackColor = True
        ' 
        ' btnOutputAll
        ' 
        btnOutputAll.Location = New Point(327, 155)
        btnOutputAll.Name = "btnOutputAll"
        btnOutputAll.Size = New Size(264, 47)
        btnOutputAll.TabIndex = 3
        btnOutputAll.Text = "Display all data items at once"
        btnOutputAll.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(327, 219)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(264, 47)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search for a person"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSearch)
        Controls.Add(btnOutputAll)
        Controls.Add(btnColumnWise)
        Controls.Add(btnRowWise)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnRowWise As Button
    Friend WithEvents btnColumnWise As Button
    Friend WithEvents btnOutputAll As Button
    Friend WithEvents btnSearch As Button

End Class
