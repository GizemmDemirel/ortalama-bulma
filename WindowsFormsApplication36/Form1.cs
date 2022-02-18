using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayaç = 0;
            double toplam = 0;
            double ortalama;
            while (sayaç<listBox1.Items.Count)
            {
                toplam = toplam + Convert.ToDouble(listBox1.Items[sayaç]);
                 sayaç++;
            }
            ortalama = toplam / sayaç;
            label1.Text = "ortalama=" + ortalama.ToString();
        }
    }
}
 