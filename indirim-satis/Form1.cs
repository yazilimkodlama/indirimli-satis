﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirim_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            double odenecek = 0;
            
            if(rb0.Checked)
            {
                odenecek = fiyat; //İndirim yok
            }
            else if(rb5.Checked)
            {
                odenecek = fiyat * 0.95; //%5 indirim
            }
            else if(rb30.Checked)
            {
                odenecek = fiyat * 0.70; //%30 indirim
            }
            else
            {
                odenecek = fiyat * 0.60;  //%40 indirim
            }


            lblOdenecekTutar.Text="Ödenecek Tutar: "+odenecek.ToString()+" ₺";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb0.Checked = true;           
        }
    }
}
