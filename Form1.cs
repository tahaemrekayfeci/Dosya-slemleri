using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosyaİslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }




        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            string tel, tckimlik, ad, soyad, cinsiyet, eposta;
            tel = txt_tel.Text;
            tckimlik = txt_kimlik.Text;
            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            eposta = txt_eposta.Text;
            if (erkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }
            string directory = "C:\\Users\\l6_pc5\\Desktop\\Test";
            string file = "C:\\Users\\l6_pc5\\Desktop\\Test\\veritabani.txt";
            Directory.CreateDirectory(directory);
            StreamWriter sw = File.AppendText(file);
            //StreamWriter sw = new StreamWriter(stream);
            sw.WriteLine(ad+" "+soyad);
            sw.WriteLine(tel);
            sw.WriteLine(tckimlik);
            sw.WriteLine(eposta);
            sw.WriteLine(cinsiyet);

            sw.Close();
        }








    }
}
  
