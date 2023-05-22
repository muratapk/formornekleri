using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formornekleri
{
    public partial class Form1 : Form
    {
        string[] ogrenciad = new string[10];
        int[] notlar = new int[10];
        int sira = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Öğrenci Adını veya  Boş Bıraktınız");
            }
            else
            {

                ogrenciad[sira] = textBox1.Text;
                notlar[sira] = Convert.ToInt32(textBox2.Text);
                sira++;
                if (sira == 10)
                {
                    button1.Enabled= false;
                    button1.BackColor = Color.Red;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(ogrenciad[i]+"\t"+notlar[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (notlar[i] > 85)
                {
                    listBox1.Items.Add(ogrenciad[i] + "\t" + notlar[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (notlar[i] <= 50)
                {
                    listBox1.Items.Add(ogrenciad[i] + "\t" + notlar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (notlar[i] > 50)
                {
                    listBox1.Items.Add(ogrenciad[i] + "\t" + notlar[i]);
                }
            }
        }
    }
}
