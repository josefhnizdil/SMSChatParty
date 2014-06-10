Public Class nastaveni

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog


        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "Všechny soubory|*.*|Bitmapové soubory .jpg, .gif, .bmp(*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then

                PictureBox1.Image = Image.FromFile(.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End With
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            PictureBox1.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        Else : CheckBox4.Checked = False
            PictureBox1.Enabled = False
            Button1.Enabled = False
            PictureBox1.Image = Nothing
            Button2.Enabled = False
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Projektor.TableLayoutPanel1.BackgroundImage = PictureBox1.Image
        Projektor.TableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch



    End Sub
End Class