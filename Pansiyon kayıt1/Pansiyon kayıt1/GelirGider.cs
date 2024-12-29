using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_kayıt1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }




        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=AyCiceğiPansiyon;Integrated Security=True;");




        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            Lblmaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(Lblkasatoplam.Text) - (Convert.ToInt16(Lblmaas.Text) + Convert.ToInt32(Lblalınan1.Text) + Convert.ToInt32(Lblalınan2.Text) + Convert.ToInt32(Lblalınan3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));    
            Lblsonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {   


            //Kasada ki toplam tutar 

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(Ucret)  as toplam from MüşteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Lblkasatoplam.Text = oku["toplam"].ToString();


            }
            baglanti.Close();

            //Gıda Giderleri


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select sum(Gıda)  as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Lblalınan1.Text = oku2["toplam1"].ToString();


            }
            baglanti.Close();

            //İçecekler

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select sum(İcecek)  as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Lblalınan2.Text = oku3["toplam2"].ToString();


            }
            baglanti.Close();

            //Cerezler

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select sum(Cerezler)  as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Lblalınan3.Text = oku4["toplam3"].ToString();


            }
            baglanti.Close();

            //elektirik

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select sum(Elektirik)  as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam4"].ToString();


            }
            baglanti.Close();

            //Su

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select sum(Su)  as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6= komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam5"].ToString();


            }
            baglanti.Close();

            //İnternet

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" select sum(İnternet)  as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam6"].ToString();


            }
            baglanti.Close();




        }
    }
}
