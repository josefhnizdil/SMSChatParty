Public Class HlavniForm

    Private Sub OProgramuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OProgramuToolStripMenuItem.Click
        oprogramu.ShowDialog()
    End Sub

    Private Sub KonecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonecToolStripMenuItem.Click
        End
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

    End Sub

    Private Sub NastaveníModemuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NastaveníModemuToolStripMenuItem.Click
        PripojeniTelefonu.ShowDialog()
    End Sub

    Private Sub HlavniForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel3.Visible = False
        ToolStripProgressBar1.Visible = False

        ToolStripStatusLabel4.Visible = False
        ToolStripProgressBar2.Visible = False

    End Sub

    Private Sub FiltrNevhodnýchSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrNevhodnýchSMSToolStripMenuItem.Click
        nevhodnesms.ShowDialog()
    End Sub

    Private Sub NastaveníZobrazeníToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NastaveníZobrazeníToolStripMenuItem.Click
        nastaveni.ShowDialog()
    End Sub

    Private Sub TableLayoutPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Projektor.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Projektor.Label1.Text = TextBox1.Text
        Projektor.Label2.Text = TextBox2.Text
        Projektor.Label3.Text = TextBox3.Text
    End Sub
End Class
