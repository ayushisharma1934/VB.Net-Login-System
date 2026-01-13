<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        Label2 = New Label()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(281, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 37)
        Label1.TabIndex = 0
        Label1.Text = "BILLING SYSTEM"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(32, 133)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(107, 24)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "PIZZA   200"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(32, 181)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(89, 24)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "TEA    20"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(32, 226)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(109, 24)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "COFFEE   80"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(32, 274)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 4
        CheckBox4.Text = "PATTIES 20"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(32, 317)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(114, 24)
        CheckBox5.TabIndex = 5
        CheckBox5.Text = "CUPCAKE 50"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(32, 360)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(103, 24)
        CheckBox6.TabIndex = 6
        CheckBox6.Text = "JUICE     25"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 22)
        Label2.TabIndex = 7
        Label2.Text = "MENU"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(465, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 64)
        Button1.TabIndex = 8
        Button1.Text = "TOTAL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.InactiveCaption
        RichTextBox1.Location = New Point(443, 274)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(252, 120)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Name = "billing"
        Text = "billing"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
