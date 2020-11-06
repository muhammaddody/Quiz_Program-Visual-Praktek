Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Makanan")
        ComboBox1.Items.Add("Material Makanan")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case (Me.ComboBox1.Text)
            Case ("Makanan")
                Me.TextBox1.Text = "Andi"
                Me.TextBox2.Text = "Karyawan Biasa"
                Me.TextBox3.Text = "200000"
            Case ("Material Makanan")
                Me.TextBox1.Text = "Dian"
                Me.TextBox2.Text = "Kurir"
                Me.TextBox3.Text = "150000"
        End Select
    End Sub
End Class
