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
    public partial class FrmYeniMüsteri : Form
    {
        public FrmYeniMüsteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=AyCiceğiPansiyon;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }
       

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text+"')" , baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

                    
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadı) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadı)values   ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadı)values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnBoş_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void DtÇıkış_ValueChanged(object sender, EventArgs e)
        {
            int UCRET;
            DateTime kucukTarih = Convert.ToDateTime(DtGiriş.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtÇıkış.Text);
            TimeSpan sonuc;
           sonuc =  buyukTarih - kucukTarih;

            label10.Text = sonuc.TotalDays.ToString();
            UCRET = Convert.ToInt32(label10.Text) * 50;    
            TxtUcret.Text = UCRET.ToString();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MüşteriEkle (Adi,Soyadı,Cinsiyet,Telefon,TC,OdaNo,Ucret,GirisTarihi,ÇıkışTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTel.Text + "','" + TxtTc.Text +"','" + TxtOdano.Text + "','" + TxtUcret.Text + "','" +DtGiriş.Value.ToString("yyyy-MM-dd") + "','" + DtÇıkış.Value.ToString("yyyy-MM-dd")+  "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kayıdı Yapıldı");
        }

        private void FrmYeniMüsteri_Load(object sender, EventArgs e)
        {
            //Oda101

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())

            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }
           




            //Oda102


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())

            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }



            //Oda103

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())

            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            //Oda104

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())

            {
                BtnOda103.Text = oku4["Adi"].ToString() + " " + oku4["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }



            //Oda105

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())

            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }


            //ODa106


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())

            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }

            //Oda107

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())

            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }

            //Oda108


            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())

            {
                BtnOda103.Text = oku8["Adi"].ToString() + " " + oku8["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }



            //Oda

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())

            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }
    }
}
 