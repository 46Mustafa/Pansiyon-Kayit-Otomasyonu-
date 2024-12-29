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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=AKTAS;Initial Catalog=AyCiceğiPansiyon;Integrated Security=True;");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar1", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesajlar"].ToString());


                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Mesajlar1(Adsoyad,Mesajlar) values ('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            verilergoster();
        }



        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }
    }
}
