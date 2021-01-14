using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            txtFaktoriyel.Text = faktoriyel.ToString();
        }
    }
}
