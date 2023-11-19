Imports System.IO
Public Class FormSurfaceTemp

    Private Sub FormSurfaceTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.RadioButtonETM.Select()
        Me.LabelTmK1.Text = ""
        Me.LabelTmK2.Text = ""
        Me.LabelEtmK1.Text = ""
        Me.LabelEtmK2.Text = ""
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.RadioButtonTM.Checked = False
        Me.RadioButtonETM.Checked = False
        Me.Label6.Text = ""
        Me.btnOK.Enabled = True
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select Kinetic Temperature File"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = ""
            Dim loadFileName1 As String = OpenFD.FileName

            'show the full path of selected file in TextBox1
            TextBox1.AppendText(loadFileName1)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveFD.InitialDirectory = "C:\"
        SaveFD.Title = "Save Output File As..."
        SaveFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (SaveFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox2.Text = ""
            Dim saveFileName As String = SaveFD.FileName
            'show the full path of selected file
            TextBox2.AppendText(saveFileName)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If RadioButtonTM.Checked = False And RadioButtonETM.Checked = False Then
            MessageBox.Show("Oops! You forgot to select a landsat platform first!", "Warning!")
            Me.btnBrowse.Focus()
        Else

            If RadioButtonETM.Checked = True Then

                If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
                    MessageBox.Show("Please browse the input file and then select the directory path to save in!", "Warning!")
                    Me.btnBrowse.Focus()
                Else
                    Me.Cursor = Cursors.WaitCursor
                    Me.PictureBox1.Visible = True
                    Me.PictureBox1.Update()
                    Me.btnOK.Enabled = False

                    Me.Label6.Visible = False
                    Me.Label6.Update()
                    Me.Label3.Text = "Processing... Please Wait!"
                    Me.Label3.Update()

                    'Me.Label6.Text = "Processing... Please Wait!"
                    'Me.Label6.Update()

                    Dim s1 As FileStream 'Load file 1
                    Dim s3 As FileStream 'Save output

                    If System.IO.File.Exists(TextBox2.Text) Then
                        System.IO.File.Delete(TextBox2.Text)
                    End If

                    '---read from and write to a binary file
                    s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
                    s3 = New FileStream(TextBox2.Text, FileMode.CreateNew, FileAccess.Write)

                    Dim br1 As BinaryReader
                    Dim bw As BinaryWriter

                    br1 = New BinaryReader(s1)
                    bw = New BinaryWriter(s3)

                    Dim fLen1 As Integer
                    Dim f1 As New System.IO.FileInfo(TextBox1.Text)

                    fLen1 = Int(f1.Length / 4)

                    'Dim snglRead1(fLen1) As Single
                    'Dim snglOutput(fLen1) As Single 'wıll hold results from division

                    Dim snglRead1 As Single
                    Dim snglOutput As Single 'wıll hold results from division

                    Dim i As Integer
                    'Dim m As Integer

                    Dim K1 As Single
                    Dim K2 As Single

                    K1 = 666.09
                    K2 = 1282.71

                    'K1 = CSng(TextBox3.Text)
                    'K2 = CSng(TextBox4.Text)

                    For i = 0 To fLen1 - 1
                        snglRead1 = br1.ReadSingle()
                        snglOutput = (K2 / (Math.Log((K1 / snglRead1) + 1)) - 273.15)

                        bw.Write(snglOutput)
                    Next

                    'For m = 0 To fLen1 - 1
                    '    snglOutput(m) = (K2 / (Math.Log((K1 / snglRead1(m)) + 1)))

                    '    bw.Write(snglOutput(m))
                    'Next

                    s1.Close()
                    s3.Close()

                    Me.PictureBox1.Visible = False
                    Me.PictureBox2.Visible = True

                    Me.Label3.Visible = False
                    Me.Label3.Update()
                    Me.Label6.Visible = True
                    Me.Label6.Text = "Process Completed!"
                    Me.Label6.Update()

                    'Me.Label6.Text = "Process Completed!"
                    'Me.Label6.Update()
                    btnCancel.Text = "Close"
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("File created succesfully!", "Success!")
                    'Me.Close()
                End If
            End If



            If RadioButtonTM.Checked = True Then

                If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
                    MessageBox.Show("Please browse the input file and then select the directory path to save in!", "Warning!")
                    Me.btnBrowse.Focus()
                Else
                    Me.Cursor = Cursors.WaitCursor
                    Me.PictureBox1.Visible = True
                    Me.PictureBox1.Update()
                    Me.btnOK.Enabled = False

                    Me.Label6.Visible = False
                    Me.Label6.Update()
                    Me.Label3.Text = "Processing... Please Wait!"
                    Me.Label3.Update()

                    'Me.Label6.Text = "Processing... Please Wait!"
                    'Me.Label6.Update()

                    Dim s1 As FileStream 'Load file 1
                    Dim s3 As FileStream 'Save output

                    If System.IO.File.Exists(TextBox2.Text) Then
                        System.IO.File.Delete(TextBox2.Text)
                    End If

                    '---read from and write to a binary file
                    s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)
                    s3 = New FileStream(TextBox2.Text, FileMode.CreateNew, FileAccess.Write)

                    Dim br1 As BinaryReader
                    Dim bw As BinaryWriter

                    br1 = New BinaryReader(s1)
                    bw = New BinaryWriter(s3)

                    Dim fLen1 As Integer
                    Dim f1 As New System.IO.FileInfo(TextBox1.Text)

                    fLen1 = Int(f1.Length / 4)

                    'Dim snglRead1(fLen1) As Single
                    'Dim snglOutput(fLen1) As Single 'wıll hold results from division

                    Dim snglRead1 As Single
                    Dim snglOutput As Single 'wıll hold results from division

                    Dim i As Integer
                    'Dim m As Integer

                    Dim K1 As Single
                    Dim K2 As Single

                    K1 = 607.76
                    K2 = 1260.56

                    'K1 = CSng(TextBox3.Text)
                    'K2 = CSng(TextBox4.Text)

                    For i = 0 To fLen1 - 1
                        snglRead1 = br1.ReadSingle()
                        snglOutput = (K2 / (Math.Log((K1 / snglRead1) + 1)) - 273.15)

                        bw.Write(snglOutput)
                    Next

                    'For m = 0 To fLen1 - 1
                    '    snglOutput(m) = (K2 / (Math.Log((K1 / snglRead1(m)) + 1)))

                    '    bw.Write(snglOutput(m))
                    'Next

                    s1.Close()
                    s3.Close()

                    Me.PictureBox1.Visible = False
                    Me.PictureBox2.Visible = True

                    Me.Label3.Visible = False
                    Me.Label3.Update()
                    Me.Label6.Visible = True
                    Me.Label6.Text = "Process Completed!"
                    Me.Label6.Update()

                    'Me.Label6.Text = "Process Completed!"
                    'Me.Label6.Update()
                    btnCancel.Text = "Close"
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("File created succesfully!", "Success!")
                    'Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Then
            e.Handled = False
        Else
            MessageBox.Show("Please Enter Numbers Only!")
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonETM.Click
        If RadioButtonETM.Checked = True Then
            Me.LabelEtmK1.Text = "K1: 666.09"
            Me.LabelEtmK2.Text = "K2: 1282.71"
            Me.LabelTmK1.Text = ""
            Me.LabelTmK2.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonTM.Click
        If RadioButtonTM.Checked = True Then
            Me.LabelEtmK1.Text = ""
            Me.LabelEtmK2.Text = ""
            Me.LabelTmK1.Text = "K1: 607.76"
            Me.LabelTmK2.Text = "K2: 1260.56"
        End If
    End Sub
End Class