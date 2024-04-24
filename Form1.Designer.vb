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
        Me.txtToko = New System.Windows.Forms.Label()
        Me.Lblnofak = New System.Windows.Forms.Label()
        Me.Lblnapel = New System.Windows.Forms.Label()
        Me.Lblharga = New System.Windows.Forms.Label()
        Me.Lbljumlah = New System.Windows.Forms.Label()
        Me.LblTohar = New System.Windows.Forms.Label()
        Me.Lblnabar = New System.Windows.Forms.Label()
        Me.Lbldiskon = New System.Windows.Forms.Label()
        Me.Lbltobal = New System.Windows.Forms.Label()
        Me.Cmdsimpan = New System.Windows.Forms.Button()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.Txtnofak = New System.Windows.Forms.TextBox()
        Me.Txtnapel = New System.Windows.Forms.TextBox()
        Me.Txtnabar = New System.Windows.Forms.TextBox()
        Me.Txtharga = New System.Windows.Forms.TextBox()
        Me.Txtjumlah = New System.Windows.Forms.TextBox()
        Me.Txtdiskon = New System.Windows.Forms.TextBox()
        Me.LblHasilTohar = New System.Windows.Forms.Label()
        Me.LblHasilTobar = New System.Windows.Forms.Label()
        Me.Symbol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtToko
        '
        Me.txtToko.AutoSize = True
        Me.txtToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToko.Location = New System.Drawing.Point(362, 46)
        Me.txtToko.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtToko.Name = "txtToko"
        Me.txtToko.Size = New System.Drawing.Size(409, 40)
        Me.txtToko.TabIndex = 0
        Me.txtToko.Text = "Toko Makmur Sentosa "
        '
        'Lblnofak
        '
        Me.Lblnofak.AutoSize = True
        Me.Lblnofak.Location = New System.Drawing.Point(90, 160)
        Me.Lblnofak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblnofak.Name = "Lblnofak"
        Me.Lblnofak.Size = New System.Drawing.Size(106, 20)
        Me.Lblnofak.TabIndex = 1
        Me.Lblnofak.Text = "Nomor Faktur"
        '
        'Lblnapel
        '
        Me.Lblnapel.AutoSize = True
        Me.Lblnapel.Location = New System.Drawing.Point(90, 222)
        Me.Lblnapel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblnapel.Name = "Lblnapel"
        Me.Lblnapel.Size = New System.Drawing.Size(131, 20)
        Me.Lblnapel.TabIndex = 2
        Me.Lblnapel.Text = "Nama Pelanggan"
        '
        'Lblharga
        '
        Me.Lblharga.AutoSize = True
        Me.Lblharga.Location = New System.Drawing.Point(90, 346)
        Me.Lblharga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblharga.Name = "Lblharga"
        Me.Lblharga.Size = New System.Drawing.Size(53, 20)
        Me.Lblharga.TabIndex = 3
        Me.Lblharga.Text = "Harga"
        '
        'Lbljumlah
        '
        Me.Lbljumlah.AutoSize = True
        Me.Lbljumlah.Location = New System.Drawing.Point(90, 409)
        Me.Lbljumlah.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbljumlah.Name = "Lbljumlah"
        Me.Lbljumlah.Size = New System.Drawing.Size(60, 20)
        Me.Lbljumlah.TabIndex = 4
        Me.Lbljumlah.Text = "Jumlah"
        '
        'LblTohar
        '
        Me.LblTohar.AutoSize = True
        Me.LblTohar.Location = New System.Drawing.Point(90, 472)
        Me.LblTohar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTohar.Name = "LblTohar"
        Me.LblTohar.Size = New System.Drawing.Size(92, 20)
        Me.LblTohar.TabIndex = 5
        Me.LblTohar.Text = "Total Harga"
        '
        'Lblnabar
        '
        Me.Lblnabar.AutoSize = True
        Me.Lblnabar.Location = New System.Drawing.Point(90, 285)
        Me.Lblnabar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblnabar.Name = "Lblnabar"
        Me.Lblnabar.Size = New System.Drawing.Size(107, 20)
        Me.Lblnabar.TabIndex = 6
        Me.Lblnabar.Text = "Nama Barang"
        '
        'Lbldiskon
        '
        Me.Lbldiskon.AutoSize = True
        Me.Lbldiskon.Location = New System.Drawing.Point(90, 538)
        Me.Lbldiskon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbldiskon.Name = "Lbldiskon"
        Me.Lbldiskon.Size = New System.Drawing.Size(58, 20)
        Me.Lbldiskon.TabIndex = 7
        Me.Lbldiskon.Text = "Diskon"
        '
        'Lbltobal
        '
        Me.Lbltobal.AutoSize = True
        Me.Lbltobal.Location = New System.Drawing.Point(90, 612)
        Me.Lbltobal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltobal.Name = "Lbltobal"
        Me.Lbltobal.Size = New System.Drawing.Size(89, 20)
        Me.Lbltobal.TabIndex = 8
        Me.Lbltobal.Text = "Total Bayar"
        '
        'Cmdsimpan
        '
        Me.Cmdsimpan.Location = New System.Drawing.Point(344, 691)
        Me.Cmdsimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmdsimpan.Name = "Cmdsimpan"
        Me.Cmdsimpan.Size = New System.Drawing.Size(112, 35)
        Me.Cmdsimpan.TabIndex = 9
        Me.Cmdsimpan.Text = "Simpan"
        Me.Cmdsimpan.UseVisualStyleBackColor = True
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(566, 691)
        Me.CmdKeluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(112, 35)
        Me.CmdKeluar.TabIndex = 10
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'Txtnofak
        '
        Me.Txtnofak.Location = New System.Drawing.Point(288, 160)
        Me.Txtnofak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtnofak.Name = "Txtnofak"
        Me.Txtnofak.Size = New System.Drawing.Size(325, 26)
        Me.Txtnofak.TabIndex = 11
        '
        'Txtnapel
        '
        Me.Txtnapel.Location = New System.Drawing.Point(288, 211)
        Me.Txtnapel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtnapel.Name = "Txtnapel"
        Me.Txtnapel.Size = New System.Drawing.Size(325, 26)
        Me.Txtnapel.TabIndex = 12
        '
        'Txtnabar
        '
        Me.Txtnabar.Location = New System.Drawing.Point(288, 274)
        Me.Txtnabar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtnabar.Name = "Txtnabar"
        Me.Txtnabar.Size = New System.Drawing.Size(325, 26)
        Me.Txtnabar.TabIndex = 13
        '
        'Txtharga
        '
        Me.Txtharga.Location = New System.Drawing.Point(288, 337)
        Me.Txtharga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtharga.Name = "Txtharga"
        Me.Txtharga.Size = New System.Drawing.Size(325, 26)
        Me.Txtharga.TabIndex = 14
        '
        'Txtjumlah
        '
        Me.Txtjumlah.Location = New System.Drawing.Point(288, 405)
        Me.Txtjumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtjumlah.Name = "Txtjumlah"
        Me.Txtjumlah.Size = New System.Drawing.Size(325, 26)
        Me.Txtjumlah.TabIndex = 15
        '
        'Txtdiskon
        '
        Me.Txtdiskon.Location = New System.Drawing.Point(288, 528)
        Me.Txtdiskon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtdiskon.Name = "Txtdiskon"
        Me.Txtdiskon.Size = New System.Drawing.Size(148, 26)
        Me.Txtdiskon.TabIndex = 16
        '
        'LblHasilTohar
        '
        Me.LblHasilTohar.AutoSize = True
        Me.LblHasilTohar.Location = New System.Drawing.Point(284, 472)
        Me.LblHasilTohar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHasilTohar.Name = "LblHasilTohar"
        Me.LblHasilTohar.Size = New System.Drawing.Size(99, 20)
        Me.LblHasilTohar.TabIndex = 17
        Me.LblHasilTohar.Text = "=========="
        '
        'LblHasilTobar
        '
        Me.LblHasilTobar.AutoSize = True
        Me.LblHasilTobar.Location = New System.Drawing.Point(284, 612)
        Me.LblHasilTobar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHasilTobar.Name = "LblHasilTobar"
        Me.LblHasilTobar.Size = New System.Drawing.Size(90, 20)
        Me.LblHasilTobar.TabIndex = 18
        Me.LblHasilTobar.Text = "========="
        '
        'Symbol
        '
        Me.Symbol.AutoSize = True
        Me.Symbol.Location = New System.Drawing.Point(447, 532)
        Me.Symbol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Symbol.Name = "Symbol"
        Me.Symbol.Size = New System.Drawing.Size(23, 20)
        Me.Symbol.TabIndex = 19
        Me.Symbol.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 763)
        Me.Controls.Add(Me.Symbol)
        Me.Controls.Add(Me.LblHasilTobar)
        Me.Controls.Add(Me.LblHasilTohar)
        Me.Controls.Add(Me.Txtdiskon)
        Me.Controls.Add(Me.Txtjumlah)
        Me.Controls.Add(Me.Txtharga)
        Me.Controls.Add(Me.Txtnabar)
        Me.Controls.Add(Me.Txtnapel)
        Me.Controls.Add(Me.Txtnofak)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.Cmdsimpan)
        Me.Controls.Add(Me.Lbltobal)
        Me.Controls.Add(Me.Lbldiskon)
        Me.Controls.Add(Me.Lblnabar)
        Me.Controls.Add(Me.LblTohar)
        Me.Controls.Add(Me.Lbljumlah)
        Me.Controls.Add(Me.Lblharga)
        Me.Controls.Add(Me.Lblnapel)
        Me.Controls.Add(Me.Lblnofak)
        Me.Controls.Add(Me.txtToko)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtToko As Label
    Friend WithEvents Lblnofak As Label
    Friend WithEvents Lblnapel As Label
    Friend WithEvents Lblharga As Label
    Friend WithEvents Lbljumlah As Label
    Friend WithEvents LblTohar As Label
    Friend WithEvents Lblnabar As Label
    Friend WithEvents Lbldiskon As Label
    Friend WithEvents Lbltobal As Label
    Friend WithEvents Cmdsimpan As Button
    Friend WithEvents CmdKeluar As Button
    Friend WithEvents Txtnofak As TextBox
    Friend WithEvents Txtnapel As TextBox
    Friend WithEvents Txtnabar As TextBox
    Friend WithEvents Txtharga As TextBox
    Friend WithEvents Txtjumlah As TextBox
    Friend WithEvents Txtdiskon As TextBox
    Friend WithEvents LblHasilTohar As Label
    Friend WithEvents LblHasilTobar As Label
    Friend WithEvents Symbol As Label
End Class
