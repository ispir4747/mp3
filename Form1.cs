using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private void Form1_Load(object sender, EventArgs e)
       // {
         //   axWindowsMediaPlayer1.URL = " C:\\Users\\Monster\\Desktop\\Ahmet KAYA - Beni Vur.mp3";
        //}

        

       // private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      //  {
        //    axWindowsMediaPlayer1.URL = " C:\\Users\\Monster\\Desktop\\Ahmet KAYA - Beni Vur.mp3";
        //}

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " C:\\Users\\Monster\\Desktop\\Ahmet Kaya - Biz Üç Kişiydik(MP3_70K).mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " C:\\Users\\Monster\\Desktop\\Ahmet KAYA - Beni Vur.mp3";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\AHMET KAYA AGLADIKCA.mp3";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet Kaya Amenna.mp3";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\AHMET KAYA BAHTİYAR.mp3";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet kaya BASKALDIRIYORUM!!S.MP3";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet kaya DAGLARDAKAROLSAYDIM!!S.MP3";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\AHMET KAYA İçimde Ölen Biri Var.mp3";
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet Kaya O mahur beste çalar müjganla ben ağlaşırız..mp3";
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet Kaya Yorgun Demokrat(MP3_160K).mp3";
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\YandexDisk\\Müzik\\Müzikler\\Azer bülbül-canım yanıyor.mp3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Monster\\Desktop\\muzik\\Ahmet Kaya-Dardayım.mp3";
        }
    }
}
