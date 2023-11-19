<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSurfaceTemp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSurfaceTemp))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.RadioButtonETM = New System.Windows.Forms.RadioButton
        Me.RadioButtonTM = New System.Windows.Forms.RadioButton
        Me.LabelTmK1 = New System.Windows.Forms.Label
        Me.LabelTmK2 = New System.Windows.Forms.Label
        Me.LabelEtmK1 = New System.Windows.Forms.Label
        Me.LabelEtmK2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 221)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(359, 20)
        Me.TextBox2.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(377, 161)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(377, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save As..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(142, 316)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(258, 316)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Path to the kinetic temperature file (data type float)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Path to the output file (data type float)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(440, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NOTE: Please select one of the platforms above..."
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(66, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(386, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 253)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 253)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'RadioButtonETM
        '
        Me.RadioButtonETM.AutoSize = True
        Me.RadioButtonETM.Location = New System.Drawing.Point(258, 12)
        Me.RadioButtonETM.Name = "RadioButtonETM"
        Me.RadioButtonETM.Size = New System.Drawing.Size(98, 17)
        Me.RadioButtonETM.TabIndex = 16
        Me.RadioButtonETM.TabStop = True
        Me.RadioButtonETM.Text = "Landsat 7 ETM"
        Me.RadioButtonETM.UseVisualStyleBackColor = True
        '
        'RadioButtonTM
        '
        Me.RadioButtonTM.AutoSize = True
        Me.RadioButtonTM.Location = New System.Drawing.Point(85, 12)
        Me.RadioButtonTM.Name = "RadioButtonTM"
        Me.RadioButtonTM.Size = New System.Drawing.Size(91, 17)
        Me.RadioButtonTM.TabIndex = 17
        Me.RadioButtonTM.TabStop = True
        Me.RadioButtonTM.Text = "Landsat 5 TM"
        Me.RadioButtonTM.UseVisualStyleBackColor = True
        '
        'LabelTmK1
        '
        Me.LabelTmK1.Location = New System.Drawing.Point(107, 42)
        Me.LabelTmK1.Name = "LabelTmK1"
        Me.LabelTmK1.Size = New System.Drawing.Size(100, 23)
        Me.LabelTmK1.TabIndex = 18
        Me.LabelTmK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTmK2
        '
        Me.LabelTmK2.Location = New System.Drawing.Point(107, 69)
        Me.LabelTmK2.Name = "LabelTmK2"
        Me.LabelTmK2.Size = New System.Drawing.Size(100, 23)
        Me.LabelTmK2.TabIndex = 19
        Me.LabelTmK2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEtmK1
        '
        Me.LabelEtmK1.Location = New System.Drawing.Point(280, 42)
        Me.LabelEtmK1.Name = "LabelEtmK1"
        Me.LabelEtmK1.Size = New System.Drawing.Size(100, 23)
        Me.LabelEtmK1.TabIndex = 20
        '
        'LabelEtmK2
        '
        Me.LabelEtmK2.Location = New System.Drawing.Point(280, 69)
        Me.LabelEtmK2.Name = "LabelEtmK2"
        Me.LabelEtmK2.Size = New System.Drawing.Size(100, 23)
        Me.LabelEtmK2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(66, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(386, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormSurfaceTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 351)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelEtmK2)
        Me.Controls.Add(Me.LabelEtmK1)
        Me.Controls.Add(Me.LabelTmK2)
        Me.Controls.Add(Me.LabelTmK1)
        Me.Controls.Add(Me.RadioButtonTM)
        Me.Controls.Add(Me.RadioButtonETM)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSurfaceTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surface Temperature Calculation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButtonETM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTM As System.Windows.Forms.RadioButton
    Friend WithEvents LabelTmK1 As System.Windows.Forms.Label
    Friend WithEvents LabelTmK2 As System.Windows.Forms.Label
    Friend WithEvents LabelEtmK1 As System.Windows.Forms.Label
    Friend WithEvents LabelEtmK2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
