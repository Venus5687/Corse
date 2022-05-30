Public Class Form1
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Select repo to download debs."
        Button2.Show()
        Button3.Show()
        TextBox2.Show()
        RadioButton1.Show()
        Button1.Hide()
        Button4.Show()
        RadioButton2.Show()
        RadioButton3.Show()
        Button6.Show()
        Button7.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel1.Hide()
        PictureBox5.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Panel1.Hide()
        PictureBox5.Visible = False
        If RadioButton1.Checked = True Then
            RadioButton1.Text = TextBox1.Text
        End If
        If RadioButton2.Checked = True Then
            RadioButton2.Text = TextBox1.Text
        End If
        If RadioButton3.Checked = True Then
            RadioButton3.Text = TextBox1.Text
        End If
        If TextBox1.Text = "" Then
            Panel1.Show()
            PictureBox5.Visible = True
            MsgBox("Invalid repo: Please enter a repo.", MsgBoxStyle.Critical, "ERROR!")
        End If
        If TextBox1.Text.Contains("https://") Then
            Panel1.Show()
            PictureBox5.Visible = True
            MsgBox("Invalid repo: Convert https to http to put a repo.", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RadioButton1.Text = "Removed"
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button4.Hide()
        TextBox2.Hide()
        RadioButton2.Hide()
        RadioButton3.Hide()
        Button6.Hide()
        Button7.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Text = "Go to link."
        Button2.Hide()
        Button3.Hide()
        RadioButton1.Hide()
        Button1.Hide()
        TextBox2.Hide()
        Button4.Hide()
        Button5.Show()
        RadioButton2.Hide()
        RadioButton3.Hide()
        Button6.Hide()
        Button7.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then
            If RadioButton1.Text = "http://apt.thebigboss.org/" Then
                Process.Start(RadioButton1.Text & "repofiles/cydia/")
            Else
                Process.Start(RadioButton1.Text & "debs/" & TextBox2.Text)
            End If
        End If
        If RadioButton2.Checked = True Then
            If RadioButton1.Text = "http://apt.thebigboss.org/" Then
                Process.Start(RadioButton1.Text & "repofiles/cydia/")
            Else
                Process.Start(RadioButton1.Text & "debs/" & TextBox2.Text)
            End If
        End If
        If RadioButton3.Checked = True Then
            If RadioButton1.Text = "http://apt.thebigboss.org/" Then
                Process.Start(RadioButton1.Text & "repofiles/cydia/")
            Else
                Process.Start(RadioButton1.Text & "debs/" & TextBox2.Text)
            End If
        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Venus5687/Corse")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        RadioButton2.Text = "Removed"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        RadioButton3.Text = "Removed"
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        Label1.Text = "Select repo to download debs."
        Button2.Show()
        Button3.Show()
        RadioButton1.Show()
        Button1.Show()
        TextBox2.Show()
        Button4.Show()
        Button5.Hide()
        RadioButton2.Show()
        RadioButton3.Show()
        Button6.Show()
        Button7.Show()
    End Sub
End Class
