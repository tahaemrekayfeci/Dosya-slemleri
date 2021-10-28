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



            string directory = "C:\\Users\\l6_pc5\\Desktop\\Test";
            string file = "C:\\Users\\l6_pc5\\Desktop\\Test\\veritabani.txt";
            Directory.CreateDirectory(directory);
            StreamWriter sw = File.AppendText(file);
            //StreamWriter sw = new StreamWriter(stream);
            sw.WriteLine("Efe Üjlerjj");
            sw.Write("İkinci satır ");
            sw.WriteLine("ve devamı.");
            sw.WriteLine("Üçüncü satır.");
            sw.Close();



            //FileStream stream = File.Create("C:\\Users\\l6_pc5\\Desktop\\Test\\veritabani.txt");
            //StreamWriter sw = new StreamWriter(stream);
            //sw.WriteLine("Tek satır metin.");
            //sw.WriteLine(" Kokova Ni ivviyiu.");


        }





        // string tel, tckimlik,ad,soyad,cinsiyet,eposta;
        //tel = txt_tel.Text;
        //tckimlik = txt_kimlik.Text;
        //ad = txt_ad.Text;
        //soyad = txt_soyad.Text;
        //eposta = txt_eposta.Text;
        //if (erkek.Checked==true)
        //{
        //    cinsiyet = "Erkek";
        //}
        //else
        //{
        //    cinsiyet = "Kadın";
        //}


    }
}
  
