using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_4_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            do
            {
                rtxtSayi.Text = rtxtSayi.Text + sayi.ToString();
                sayi++;
            } while (sayi <= 30);
        }
    }
}
