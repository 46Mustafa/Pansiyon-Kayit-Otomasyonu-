using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_kayıt1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMüsteri fr = new FrmYeniMüsteri();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar(); 
            fr.Show();  
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmMüsteriler fr = new FrmMüsteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay Çiçeği Pansiyon Kayıt Uygulaması  /  2010 - KahramanMaraş"); 
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
              timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar frm= new FrmStoklar();   
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMüzik frm = new FrmMüzik();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler frm = new FrmGazeteler();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();    
            frm.Show(); 
        }
    }
}
