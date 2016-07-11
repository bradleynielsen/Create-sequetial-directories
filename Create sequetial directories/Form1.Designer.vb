<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.buttonChooseDirectory = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.textboxChosenDirectory = New System.Windows.Forms.Label()
        Me.textboxNumber = New System.Windows.Forms.TextBox()
        Me.buttonMakeDirectories = New System.Windows.Forms.Button()
        Me.checkboxZeroPad = New System.Windows.Forms.CheckBox()
        Me.labelNumberOfFolder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        '
        'buttonChooseDirectory
        '
        Me.buttonChooseDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonChooseDirectory.Location = New System.Drawing.Point(12, 25)
        Me.buttonChooseDirectory.Name = "buttonChooseDirectory"
        Me.buttonChooseDirectory.Size = New System.Drawing.Size(140, 80)
        Me.buttonChooseDirectory.TabIndex = 0
        Me.buttonChooseDirectory.Text = "Choose Location"
        Me.buttonChooseDirectory.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(618, 307)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(140, 80)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'textboxChosenDirectory
        '
        Me.textboxChosenDirectory.AutoSize = True
        Me.textboxChosenDirectory.Location = New System.Drawing.Point(12, 9)
        Me.textboxChosenDirectory.Name = "textboxChosenDirectory"
        Me.textboxChosenDirectory.Size = New System.Drawing.Size(81, 13)
        Me.textboxChosenDirectory.TabIndex = 4
        Me.textboxChosenDirectory.Text = "No directory set"
        '
        'textboxNumber
        '
        Me.textboxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxNumber.Location = New System.Drawing.Point(12, 153)
        Me.textboxNumber.Name = "textboxNumber"
        Me.textboxNumber.Size = New System.Drawing.Size(210, 80)
        Me.textboxNumber.TabIndex = 5
        '
        'buttonMakeDirectories
        '
        Me.buttonMakeDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMakeDirectories.Location = New System.Drawing.Point(12, 304)
        Me.buttonMakeDirectories.Name = "buttonMakeDirectories"
        Me.buttonMakeDirectories.Size = New System.Drawing.Size(140, 80)
        Me.buttonMakeDirectories.TabIndex = 6
        Me.buttonMakeDirectories.Text = "Make Folders"
        Me.buttonMakeDirectories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonMakeDirectories.UseVisualStyleBackColor = True
        '
        'checkboxZeroPad
        '
        Me.checkboxZeroPad.AutoSize = True
        Me.checkboxZeroPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.checkboxZeroPad.Location = New System.Drawing.Point(15, 239)
        Me.checkboxZeroPad.Name = "checkboxZeroPad"
        Me.checkboxZeroPad.Size = New System.Drawing.Size(114, 38)
        Me.checkboxZeroPad.TabIndex = 7
        Me.checkboxZeroPad.Text = "Fixed Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Length"
        Me.checkboxZeroPad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxZeroPad.UseVisualStyleBackColor = True
        '
        'labelNumberOfFolder
        '
        Me.labelNumberOfFolder.AutoSize = True
        Me.labelNumberOfFolder.Location = New System.Drawing.Point(12, 137)
        Me.labelNumberOfFolder.Name = "labelNumberOfFolder"
        Me.labelNumberOfFolder.Size = New System.Drawing.Size(178, 13)
        Me.labelNumberOfFolder.TabIndex = 8
        Me.labelNumberOfFolder.Text = "Enter the number of folders to make:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 389)
        Me.Controls.Add(Me.labelNumberOfFolder)
        Me.Controls.Add(Me.checkboxZeroPad)
        Me.Controls.Add(Me.buttonMakeDirectories)
        Me.Controls.Add(Me.textboxNumber)
        Me.Controls.Add(Me.textboxChosenDirectory)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonChooseDirectory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents buttonChooseDirectory As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents textboxChosenDirectory As Label
    Friend WithEvents textboxNumber As TextBox
    Friend WithEvents buttonMakeDirectories As Button
    Friend WithEvents checkboxZeroPad As CheckBox
    Friend WithEvents labelNumberOfFolder As Label
End Class
