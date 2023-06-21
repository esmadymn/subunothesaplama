using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace odevbys
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
           
        }

        public static double hesapla(string harf, double akts) 
        {
            if (harf == "AA")
                return akts * 4.00;
            else if (harf == "BA")
                return akts * 3.50;
            else if (harf == "BB")
                return akts * 3.00;
            else if (harf == "CB")
                return akts * 2.50;
            else if (harf == "CC")
                return akts * 2.00;
            else if (harf == "DC")
                return akts * 1.50;
            else if (harf == "DD")
                return akts * 1.00;
            else if (harf == "FD")
                return akts * 0.50;
            else
                return 0;
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            //1.dönem puanları 
            double puan1, puan2, puan3, puan4, puan5, puan6, puan7;
            double toplam = 0, ortalama = 0;

            puan1 = hesapla(comboBox1.Text, 5); 
            puan2 = hesapla(comboBox2.Text, 4); 
            puan3 = hesapla(comboBox3.Text, 4); 
            puan4 = hesapla(comboBox4.Text, 5); 
            puan5 = hesapla(comboBox5.Text, 5); 
            puan6 = hesapla(comboBox6.Text, 3); 
            puan7 = hesapla(comboBox7.Text, 4); 

            toplam = puan1 + puan2 + puan3 + puan4 + puan5 + puan6 + puan7;
            ortalama = toplam / 30;

            txtdnmpuan.Text = toplam.ToString();
            txtdnmortalama.Text = ortalama.ToString();

            //2.dönem puanları 
            double puan8, puan9, puan10, puan11, puan12, puan13, puan14;
            double toplam2 = 0, ortalama2 = 0;

            puan8 = hesapla(comboBox8.Text, 4); 
            puan9 = hesapla(comboBox9.Text, 6);
            puan10 = hesapla(comboBox10.Text, 4);
            puan11 = hesapla(comboBox11.Text, 4); 
            puan12 = hesapla(comboBox12.Text, 5); 
            puan13 = hesapla(comboBox13.Text, 4); 
            puan14 = hesapla(comboBox14.Text, 3); 

            toplam2 = puan8 + puan9 + puan10 + puan11 + puan12 + puan13 + puan14;
            ortalama2 = toplam2 / 30;

            txtdnmpuan2.Text = toplam2.ToString();
            txtdnmortalama2.Text = ortalama2.ToString();


            //3.dönem puanları
            double puan15, puan16, puan17, puan18, puan19, puan20, puan21;
            double toplam3 = 0, ortalama3 = 0;

            puan15 = hesapla(comboBox15.Text, 4); 
            puan16 = hesapla(comboBox16.Text, 4); 
            puan17 = hesapla(comboBox17.Text, 4); 
            puan18 = hesapla(comboBox18.Text, 5); 
            puan19 = hesapla(comboBox19.Text, 5);
            puan20 = hesapla(comboBox20.Text, 4); 
            puan21 = hesapla(comboBox21.Text, 4); 

            toplam3 = puan15 + puan16 + puan17 + puan18 + puan19 + puan20 + puan21;
            ortalama3 = toplam3 / 30;

            txtdnmpuan3.Text = toplam3.ToString();
            txtdnmortalama3.Text = ortalama3.ToString();


            //4.dönem puanları
            double puan22, puan23, puan24;
            double toplam4 = 0, ortalama4 = 0;

            puan22 = hesapla(comboBox22.Text, 4);
            puan23 = hesapla(comboBox23.Text, 21); 
            puan24 = hesapla(comboBox24.Text, 5); 

            toplam4 = puan22+ puan23 + puan24;
            ortalama4 = toplam4 / 25;

            txtdnmpuan4.Text = toplam4.ToString();
            txtdnmortalama4.Text = ortalama4.ToString();


            //GENEL PUAN VE ORTALAMA HESABI
            double gnlpuan, gnlpuan2, gnlpuan3, gnlpuan4, gnlortalama, gnlortalama2, gnlortalama3, gnlortalama4;

            gnlpuan = toplam;
            gnlpuan2 = (toplam + toplam2);
            gnlpuan3 = (toplam + toplam2 + toplam3);
            gnlpuan4 = (toplam + toplam2 + toplam3 + toplam4);

            gnlortalama = toplam / 30;
            gnlortalama2 = (toplam + toplam2) / 60;
            gnlortalama3 = (toplam + toplam2 + toplam3) / 90;
            gnlortalama4 = (toplam + toplam2 + toplam3 + toplam4) / 115;

            txtgnlpuan.Text = gnlpuan.ToString();
            txtgnlpuan2.Text = gnlpuan2.ToString();
            txtgnlpuan3.Text = gnlpuan3.ToString();
            txtgnlpuan4.Text = gnlpuan4.ToString();

            txtgnlortalama.Text = gnlortalama.ToString();
            txtgnlortalama2.Text = gnlortalama2.ToString();
            txtgnlortalama3.Text = gnlortalama3.ToString();
            txtgnlortalama4.Text = gnlortalama4.ToString();


        }
    }
}