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
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //PowerTürk
            //axWindowsMediaPlayer1.URL = "http://powerturktaptaze.listenpowerapp.com/powerturktaptaze/mpeg/icecast.audio";
            //Fenomen Fm
            //axWindowsMediaPlayer1.URL = " http://fenomenoriental.listenfenomen.com/fenomenpop/128/icecast.audio";
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://trkvz-radyolar.ercdn.net/asporradyo/playlist.m3u8";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://radio-trtradyohaber.live.trt.com.tr/master.m3u8";

        }
    }
}
