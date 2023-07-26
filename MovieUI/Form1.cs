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
    }
}
