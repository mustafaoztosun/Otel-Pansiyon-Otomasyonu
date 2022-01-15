﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayçiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris form = new FrmAdminGiris();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri form = new FrmYeniMusteri();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler form = new FrmMusteriler();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1985 senesinden bu yana hizmet veren Otel/Pansiyon yerimiz neredeyse her sene üstün hizmet ödülü almış bir Pansiyondur. " +
                "Alanlarında uzman ekibimizle birlikte Misafirlerimize hizmet vermekten mutluluk duyuyoruz. " +
                " Ayçiçeği Pansiyon Kayıt Uygulaması / 2021 - Bursa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar form = new FrmOdalar();
            form.Show();

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

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
