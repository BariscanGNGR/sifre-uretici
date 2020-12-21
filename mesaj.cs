using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifre_olusturucu
{
    public partial class mesaj : Form
    {
        //constructor olarak şifremizi alıyor ekrana yazdırıyor
        public mesaj(String gelen)
        {
            InitializeComponent();
            textBox1.Text = gelen;
        }

        //çıkış tuşu basınca mesaj kutusunu kapatıyor
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //eğer kopyala tuşuna basarsak 
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
