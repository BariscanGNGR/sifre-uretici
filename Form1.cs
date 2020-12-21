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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String sonuc = sifrele.hazirla(Convert.ToInt32(textBox1.Text), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked); //herşey burda başlıyor
            mesaj msj = new mesaj(sonuc); //özel mesaj boxum
            msj.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e) //eğer sayı yerine harf girilirse harfi siler ve arkasına bile bakmaz
        {
            if (textBox1.Text.Length != 0) 
            {
                char[] sayilar = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

                bool sayiMi = false;

                foreach (char s in sayilar)
                {
                    if (textBox1.Text[textBox1.Text.Length - 1] == s)
                    {
                        sayiMi = true;
                        break;
                    }
                }

                if (!sayiMi && textBox1.Text.Length > 1)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                else if (!sayiMi && textBox1.Text.Length <= 1)
                {
                    textBox1.Text = "";
                }
            }
        }
    }
}
