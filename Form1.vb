Imports MySql.Data.MySqlClient

Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=penjualan_nai"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim totbay, totharga, disc As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Cmdsimpan_Click(sender As Object, e As EventArgs) Handles Cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into transaksi values('" & Txtnofak.Text & "', " &
        " '" & Txtnapel.Text & "' , '" & Txtnabar.Text & "' , " &
        " '" & Txtharga.Text & "' , '" & Txtjumlah.Text & "' ," &
        " '" & totharga & "','" & disc & "','" & totbay & "')"
        perintah.ExecuteNonQuery()
        kon.Close()

    End Sub

    Private Sub CmdKeluar_Click(sender As Object, e As EventArgs) Handles CmdKeluar.Click
        End
    End Sub

    Private Sub Txtnofak_TextChanged(sender As Object, e As EventArgs) Handles Txtnofak.TextChanged

    End Sub

    Private Sub Txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles Txtjumlah.TextChanged
        totharga = Val(Txtharga.Text) * Val(Txtjumlah.Text)
        LblHasilTohar.Text = Format(totharga, "Rp ###,###,###")
    End Sub

    Private Sub Txtdiskon_TextChanged(sender As Object, e As EventArgs) Handles Txtdiskon.TextChanged
        disc = totharga * Val(Txtdiskon.Text) / 100
        totbay = totharga - disc
        LblHasilTobar.Text = Format(totbay, "Rp ###,###,###")

    End Sub


End Class
