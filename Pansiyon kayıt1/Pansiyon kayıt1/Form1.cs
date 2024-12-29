using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_kayıt1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=AyCiceğiPansiyon;Integrated Security=True;");

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici =@KullaniciAdi AND Sifre=@Sifresi ";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullanıcıAdı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                
                { 
                   FrmAnaForm fr=new FrmAnaForm();
                    fr.Show();
                    this.Hide();    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş!!");
         
            }


        }
    }
}
