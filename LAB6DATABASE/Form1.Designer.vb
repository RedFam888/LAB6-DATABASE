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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.btnPublishers = New System.Windows.Forms.Button()
        Me.btn1905 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(780, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Publisher Name:"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(26, 452)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(100, 20)
        Me.txtPublisher.TabIndex = 3
        '
        'btnPublishers
        '
        Me.btnPublishers.Location = New System.Drawing.Point(26, 478)
        Me.btnPublishers.Name = "btnPublishers"
        Me.btnPublishers.Size = New System.Drawing.Size(75, 23)
        Me.btnPublishers.TabIndex = 4
        Me.btnPublishers.Text = "Find"
        Me.btnPublishers.UseVisualStyleBackColor = True
        '
        'btn1905
        '
        Me.btn1905.Location = New System.Drawing.Point(201, 452)
        Me.btn1905.Name = "btn1905"
        Me.btn1905.Size = New System.Drawing.Size(75, 23)
        Me.btn1905.TabIndex = 7
        Me.btn1905.Text = "Find"
        Me.btn1905.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Books from 1905:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 767)
        Me.Controls.Add(Me.btn1905)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPublishers)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents btnPublishers As Button
    Friend WithEvents btn1905 As Button
    Friend WithEvents Label2 As Label
End Class
