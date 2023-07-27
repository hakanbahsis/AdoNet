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
    public partial class FrmLogin : Form
    {
        //SqlConnection con = new SqlConnection("data source=DESKTOP-PK98KLS;initial catalog=CasgemMovieDb;integrated security=true;");
        private string con=("data source=DESKTOP-PK98KLS;initial catalog=CasgemMovieDb;integrated security=true;");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.BackColor = randomColor;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
  
            string username = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            using (SqlConnection connection = new SqlConnection(con))
            {
                // SQL sorgusu
                string query = "SELECT COUNT(*) FROM TblAdmin WHERE Username=@Username AND Password=@Password";

                // SQL komutunu oluşturun
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleyin
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    try
                    {
                        // Veritabanı bağlantısını açın
                        connection.Open();

                        // Sorguyu çalıştırın ve sonuçları alın
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Giriş başarılı!");
                            Form1 frmPanel = new Form1();
                            frmPanel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda işleyin
                        MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    }
                }
            }
        }
    }
}
