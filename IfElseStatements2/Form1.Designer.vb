<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtSmallBio = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtSurname = New TextBox()
        txtTribe = New TextBox()
        txtYear = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        txtGender = New ListBox()
        SuspendLayout()
        ' 
        ' txtSmallBio
        ' 
        txtSmallBio.Location = New Point(522, 366)
        txtSmallBio.Name = "txtSmallBio"
        txtSmallBio.Size = New Size(249, 34)
        txtSmallBio.TabIndex = 0
        txtSmallBio.Text = "Your Small Bio"
        txtSmallBio.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(220, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(197, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 2
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(125, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 25)
        Label3.TabIndex = 3
        Label3.Text = "Year you were born in"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(245, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 4
        Label4.Text = "Tribe"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(324, 113)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(150, 31)
        txtSurname.TabIndex = 5
        ' 
        ' txtTribe
        ' 
        txtTribe.Location = New Point(324, 224)
        txtTribe.Name = "txtTribe"
        txtTribe.Size = New Size(150, 31)
        txtTribe.TabIndex = 6
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(324, 172)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(150, 31)
        txtYear.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(324, 55)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(225, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 10
        Label5.Text = "Gender"
        ' 
        ' txtGender
        ' 
        txtGender.FormattingEnabled = True
        txtGender.ItemHeight = 25
        txtGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        txtGender.Location = New Point(324, 271)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(180, 129)
        txtGender.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGender)
        Controls.Add(Label5)
        Controls.Add(txtName)
        Controls.Add(txtYear)
        Controls.Add(txtTribe)
        Controls.Add(txtSurname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSmallBio)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSmallBio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As ListBox
End Class
