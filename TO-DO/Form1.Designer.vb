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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        inputTask = New TextBox()
        btnAdd = New Button()
        TaskBox = New ListBox()
        btnRemove = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' inputTask
        ' 
        inputTask.Font = New Font("Segoe UI", 18F)
        inputTask.Location = New Point(12, 23)
        inputTask.Multiline = True
        inputTask.Name = "inputTask"
        inputTask.PlaceholderText = " -Task here! :)"
        inputTask.Size = New Size(311, 55)
        inputTask.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAdd.Location = New Point(329, 24)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(148, 55)
        btnAdd.TabIndex = 2
        btnAdd.Text = "ADD TASK"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' TaskBox
        ' 
        TaskBox.Font = New Font("Cascadia Code ExtraLight", 18F)
        TaskBox.FormattingEnabled = True
        TaskBox.ItemHeight = 32
        TaskBox.Location = New Point(12, 94)
        TaskBox.Name = "TaskBox"
        TaskBox.Size = New Size(610, 516)
        TaskBox.TabIndex = 3
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnRemove.Location = New Point(483, 25)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(139, 54)
        btnRemove.TabIndex = 4
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(637, 620)
        Controls.Add(btnRemove)
        Controls.Add(TaskBox)
        Controls.Add(btnAdd)
        Controls.Add(inputTask)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "easyOne!"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents inputTask As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents TaskBox As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
