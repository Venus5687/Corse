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
        TextBox4.Show()
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
        TextBox4.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then
            If RadioButton1.Text = "http://apt.thebigboss.org/" Then
                Process.Start(RadioButton1.Text & "repofiles/cydia/")
                If TextBox4.Text.Contains("/") Then
                    Process.Start(RadioButton1.Text & TextBox4.Text & TextBox2.Text)
                End If
            Else
                Process.Start(RadioButton1.Text & "debs/" & TextBox2.Text)
                If TextBox4.Text.Contains("/") Then
                    Process.Start(RadioButton1.Text & TextBox4.Text & TextBox2.Text)
                End If
            End If
        End If
        If RadioButton2.Checked = True Then
            Process.Start(RadioButton2.Text & "repofiles/cydia/")
            If TextBox4.Text.Contains("/") Then
                Process.Start(RadioButton2.Text & TextBox4.Text & TextBox2.Text)
            End If
        Else
            Process.Start(RadioButton2.Text & "debs/" & TextBox2.Text)
            If TextBox4.Text.Contains("/") Then
                Process.Start(RadioButton2.Text & TextBox4.Text & TextBox2.Text)
            End If
        End If
        If RadioButton3.Checked = True Then
            Process.Start(RadioButton3.Text & "repofiles/cydia/")
            If TextBox4.Text.Contains("/") Then
                Process.Start(RadioButton3.Text & TextBox4.Text & TextBox2.Text)
            End If
        Else
            Process.Start(RadioButton3.Text & "debs/" & TextBox2.Text)
            If TextBox4.Text.Contains("/") Then
                Process.Start(RadioButton3.Text & TextBox4.Text & TextBox2.Text)
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
        TextBox4.Show()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
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
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        TabPage1.BackgroundImage = My.Resources.white
        TabPage2.BackgroundImage = My.Resources.white
        TabPage3.BackgroundImage = My.Resources.white
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        RadioButton6.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click
        TabPage1.BackgroundImage = My.Resources.windows11_leak_720
        TabPage2.BackgroundImage = My.Resources.windows11_leak_720
        TabPage3.BackgroundImage = My.Resources.windows11_leak_720
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        RadioButton6.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click
        TabPage1.BackgroundImage = My.Resources.img19
        TabPage2.BackgroundImage = My.Resources.img19
        TabPage3.BackgroundImage = My.Resources.img19
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label1.ForeColor = Color.White
        RadioButton1.ForeColor = Color.White
        RadioButton2.ForeColor = Color.White
        RadioButton3.ForeColor = Color.White
        RadioButton4.ForeColor = Color.White
        RadioButton5.ForeColor = Color.White
        RadioButton6.ForeColor = Color.White
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged

    End Sub

    Private Sub RadioButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.Click
        TabPage1.BackgroundImage = My.Resources.cat
        TabPage2.BackgroundImage = My.Resources.cat
        TabPage3.BackgroundImage = My.Resources.cat
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        RadioButton6.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged

    End Sub

    Private Sub RadioButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton8.Click
        TabPage1.BackgroundImage = My.Resources._511Vl0MW_lL__AC_SY355_
        TabPage2.BackgroundImage = My.Resources._511Vl0MW_lL__AC_SY355_
        TabPage3.BackgroundImage = My.Resources._511Vl0MW_lL__AC_SY355_
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        RadioButton6.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged

    End Sub

    Private Sub RadioButton9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton9.Click
        TabPage1.BackgroundImage = My.Resources.bald
        TabPage2.BackgroundImage = My.Resources.bald
        TabPage3.BackgroundImage = My.Resources.bald
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        Label3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton3.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        RadioButton6.ForeColor = Color.Black
    End Sub
End Class
