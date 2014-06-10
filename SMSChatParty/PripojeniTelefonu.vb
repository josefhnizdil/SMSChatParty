Public Class PripojeniTelefonu

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox2.Checked = True Then
            HlavniForm.ToolStripStatusLabel4.Visible = True
            HlavniForm.ToolStripProgressBar2.Visible = True
        End If
        If CheckBox3.Checked = True Then
            HlavniForm.ToolStripStatusLabel3.Visible = True
            HlavniForm.ToolStripProgressBar1.Visible = True
        End If
    End Sub
End Class