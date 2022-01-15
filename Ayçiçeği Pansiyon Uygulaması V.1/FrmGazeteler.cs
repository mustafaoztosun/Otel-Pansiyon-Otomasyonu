using System;
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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Fotomaç
            webBrowser1.Navigate("https://www.fotomac.com.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Fanatik
            webBrowser1.Navigate("https://www.fanatik.com.tr/");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //FotoSpor 
            webBrowser1.Navigate("https://www.fotospor.com/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //TRT Spor
            webBrowser1.Navigate("https://www.trtspor.com.tr/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Onedio
            webBrowser1.Navigate("https://onedio.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Sabah
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Hürriyet
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //HaberTürk
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            //Milliyet
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }
    }
}
