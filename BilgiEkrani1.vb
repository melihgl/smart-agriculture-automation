Imports System.Data.SqlClient
Public Class BilgiEkrani1
    Dim baglanti As New SqlConnection("Data Source=.\melih;Initial Catalog=AkilliTarimOtomasyonu;Integrated Security=True")
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
    Private Sub ekleButton_click(sender As Object, e As EventArgs) Handles ekleButton.Click
        Try
            baglanti.Open()
            Dim sql As String = "INSERT INTO Bitki(Sube, Sinif, Takim, Familya, Cins, Tur, BitkiAdi) 
                                VALUES(@Sube, @Sinif, @Takim, @Familya, @Cins, @Tur, @BitkiAdi)"
            Using komut As New SqlCommand(sql, baglanti)
                komut.Parameters.AddWithValue("@Sube", txtSube.Text)
                komut.Parameters.AddWithValue("@Sinif", txtSinif.Text)
                komut.Parameters.AddWithValue("@Takim", txtTakim.Text)
                komut.Parameters.AddWithValue("@Familya", txtFamilya.Text)
                komut.Parameters.AddWithValue("@Cins", txtCins.Text)
                komut.Parameters.AddWithValue("@Tur", txtTur.Text)
                komut.Parameters.AddWithValue("@BitkiAdi", txtBitkiAdi.Text)
                komut.ExecuteNonQuery()
            End Using
            MessageBox.Show("Ekleme İşlemi Başarılı!", "Bilgi")
            Listele()
            Temizle()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            baglanti.Close()
        End Try
    End Sub
    Sub Listele()
        Dim dt As New DataTable
        Dim sql As String = "Select * from Bitki"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub Temizle()
        txtBitkiId.Text = String.Empty
        txtSube.Text = String.Empty
        txtSinif.Text = String.Empty
        txtTakim.Text = String.Empty
        txtFamilya.Text = String.Empty
        txtCins.Text = String.Empty
        txtTur.Text = String.Empty
        txtBitkiAdi.Text = String.Empty
    End Sub
    Private Sub temizleButton_Click(sender As Object, e As EventArgs) Handles temizleButton.Click
        Temizle()
    End Sub
    Private Sub BilgiEkrani1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()
    End Sub
    Private Sub cikisButton_Click(sender As Object, e As EventArgs) Handles cikisButton.Click
        Me.Close()
    End Sub
    Private Sub duzenleButton_Click(sender As Object, e As EventArgs) Handles duzenleButton.Click
        Try
            Dim sql As String = "Update Bitki set Sube=@Sube, Sinif=@Sinif, Takim=@Takim, 
            Familya=@Familya, Cins=@Cins, Tur=@Tur, BitkiAdi=@BitkiAdi Where BitkiId=@BitkiId"
            Using komut As New SqlCommand(sql, baglanti)
                komut.Parameters.AddWithValue("@Sube", txtSube.Text)
                komut.Parameters.AddWithValue("@Sinif", txtSinif.Text)
                komut.Parameters.AddWithValue("@Takim", txtTakim.Text)
                komut.Parameters.AddWithValue("@Familya", txtFamilya.Text)
                komut.Parameters.AddWithValue("@Cins", txtCins.Text)
                komut.Parameters.AddWithValue("@Tur", txtTur.Text)
                komut.Parameters.AddWithValue("@BitkiAdi", txtBitkiAdi.Text)
                komut.Parameters.AddWithValue("@BitkiId", Integer.Parse(txtBitkiId.Text))
                baglanti.Open()
                komut.ExecuteNonQuery()
            End Using
            MessageBox.Show("Düzenleme İşlemi Başarılı!", "Bilgi")
            Listele()
            Temizle()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If baglanti.State = ConnectionState.Open Then baglanti.Close()
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtBitkiId.Text = DataGridView1.CurrentRow.Cells("BitkiId").Value.ToString()
        txtSube.Text = DataGridView1.CurrentRow.Cells("Sube").Value.ToString()
        txtSinif.Text = DataGridView1.CurrentRow.Cells("Sinif").Value.ToString()
        txtTakim.Text = DataGridView1.CurrentRow.Cells("Takim").Value.ToString()
        txtFamilya.Text = DataGridView1.CurrentRow.Cells("Familya").Value.ToString()
        txtCins.Text = DataGridView1.CurrentRow.Cells("Cins").Value.ToString()
        txtTur.Text = DataGridView1.CurrentRow.Cells("Tur").Value.ToString()
        txtBitkiAdi.Text = DataGridView1.CurrentRow.Cells("BitkiAdi").Value.ToString()
    End Sub
    Private Sub silButton_Click(sender As Object, e As EventArgs) Handles silButton.Click
        If MessageBox.Show("Kayıt silinecektir. Onaylıyor musunuz?", "Uyarı",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sql As String = "Delete From Bitki
            Where BitkiId='" & Integer.Parse(DataGridView1.CurrentRow.Cells("BitkiId").Value.ToString()) & "'"
            Dim komut As New SqlCommand(sql, baglanti)
            baglanti.Open()
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Silme İşlemi Başarılı!", "Bilgi")
            Listele()
            Temizle()
        End If
    End Sub
    Private Sub txtBitkiAra_TextChanged(sender As Object, e As EventArgs) Handles txtBitkiAra.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "Select * from Bitki Where BitkiAdi like '%" & txtBitkiAra.Text & "%'"
        Dim adtr As New SqlDataAdapter(sql, baglanti)
        adtr.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
