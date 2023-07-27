using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieUI
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-PK98KLS;initial catalog=CasgemMovieDb;integrated security=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Listele()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable da = new DataTable();
            adapter.Fill(da);
            dtgKategori.DataSource = da;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
            cmbKategori.DataSource = da;
            con.Close();

            con.Open();
            SqlCommand command3 = new SqlCommand("select MovieId,MovieName,MovieImdb,MovieDuration,CategoryName from TblMovie" +
                " inner join TblCategory on TblMovie.MovieCategoryId=TblCategory.CategoryId", con);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable da3 = new DataTable();
            adapter3.Fill(da3);
            dtgMovie.DataSource = da3;
            con.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();

            
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)",con);
            command.Parameters.AddWithValue("@p1", txtKtAdi.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

          
            con.Close();
            Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region KategoriSayisi
            con.Open();
            SqlCommand command = new SqlCommand("select count(*) from TblCategory", con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblKategoriSayisi.Text = reader[0].ToString();
            }
            con.Close();
            #endregion

            #region enBasariliFilm
            con.Open();
            SqlCommand command1 = new SqlCommand("select MovieName from TblMovie where MovieImdb=(select max(MovieImdb) from TblMovie)", con);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                lblEnbasariliFilm.Text = reader1[0].ToString();
            }
            con.Close();
            #endregion

            #region FilmSayisi
            con.Open();
            SqlCommand command2 = new SqlCommand("select count(*) from TblMovie", con);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                lblFilmSayisi.Text = reader2[0].ToString();
            }
            con.Close();
            #endregion

            con.Close();
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("delete from TblCategory where CategoryId=@p1", con);
            command.Parameters.AddWithValue("@p1", txtKtId.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update TblCategory set CategoryName=@p1 where CategoryId=@p2", con);
            command.Parameters.AddWithValue("@p1", txtKtAdi.Text);
            command.Parameters.AddWithValue("@p2", txtKtId.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Listele();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into TblMovie (MovieName,MovieDuration,MovieImdb,MovieCategoryId) values(@p1,@p2,@p3,@p4)", con);
            command.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
            command.Parameters.AddWithValue("@p2", txtFilmSuresi.Text);
            command.Parameters.AddWithValue("@p3", txtFilmImdb.Text);
            command.Parameters.AddWithValue("@p4", cmbKategori.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Film Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Listele();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("delete from TblMovie where MovieId=@p1", con);
            command.Parameters.AddWithValue("@p1", txtFilmId.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Film Başarılı Bir Şekilde Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Listele();
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update TblMovie set MovieName=@p1,MovieDuration=@p2,MovieImdb=@p3,MovieCategoryId=@p4 where MovieId=@p5", con);
            command.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
            command.Parameters.AddWithValue("@p2", txtFilmSuresi.Text);
            command.Parameters.AddWithValue("@p3", txtFilmImdb.Text);
            command.Parameters.AddWithValue("@p4", cmbKategori.SelectedValue);
            command.Parameters.AddWithValue("@p5", txtFilmId.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Film Başarılı Bir Şekilde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            Listele();
        }
    }
}
