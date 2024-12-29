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
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=AyCiceğiPansiyon;Integrated Security=True;");

        private void verilergoster()
        {
            listView1.Items.Clear();     
         baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüşteriEkle",baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while (oku.Read())
            { 
              ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
              //  ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());
                
                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtOdano.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtGiriş.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtÇıkış.Text = listView1.SelectedItems[0].SubItems[9].Text;
     
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update  MüşteriEkle set Adi='" + TxtAdi.Text + "'  ,Soyadı='" + TxtSoyadi.Text + "', Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTel.Text + "' ,TC='" + TxtTc.Text + "' ,OdaNo='" + TxtOdano.Text + "',Ucret='" + TxtUcret + "' ,GirisTarihi='" + DtGiriş.Value.ToString("yyyy-MM-dd") + "',ÇıkışTarihi='" + DtÇıkış.Value.ToString("yyyy-MM-dd") + "'  where Müsteriid = " + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {

            // SqlCommand komut = new SqlCommand("delete from Müşteriekle where müsteriid=(" + id + ")",baglanti);
            //Oda101 Boşalt

            if (TxtOdano.Text == "101")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            //Oda102 Boşalt

            if (TxtOdano.Text == "102")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }


            //Oda103 Boşalt

            if (TxtOdano.Text == "103")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda104 Boşalt
            if (TxtOdano.Text == "104")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda105 Boşalt
            if (TxtOdano.Text == "105")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda106 Boşalt
            if (TxtOdano.Text == "106")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda107 Boşalt
            if (TxtOdano.Text == "107")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda108 Boşalt
            if (TxtOdano.Text == "108")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //Oda109 Boşalt
            if (TxtOdano.Text == "109")
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = " ";
            MskTel.Clear();
            TxtTc.Clear();
            TxtOdano.Clear();
            TxtUcret.Clear();
          


        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüşteriEkle  Where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
              //ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["ÇıkışTarihi"].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }

        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
