Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'button selected
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        ' tampilkan panel konten
        PanelDataMaster.Visible = True
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = False
        PanelLainnya.Visible = False
        PanelBabalongsky.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        PanelDataMaster.Visible = False
        PanelTransaksi.Visible = True
        PanelLaporan.Visible = False
        PanelLainnya.Visible = False
        PanelBabalongsky.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        PanelDataMaster.Visible = False
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = True
        PanelLainnya.Visible = False
        PanelBabalongsky.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        Label5.Visible = False
        Label6.Visible = False

        PanelDataMaster.Visible = False
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = False
        PanelLainnya.Visible = True
        PanelBabalongsky.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = True
        Label6.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = True
    End Sub

    Private Sub BtnAvatar_Click(sender As Object, e As EventArgs) Handles BtnAvatar.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        PanelDataMaster.Visible = False
        PanelTransaksi.Visible = False
        PanelLaporan.Visible = False
        PanelLainnya.Visible = False
        PanelBabalongsky.Visible = True
    End Sub
End Class
