using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waralaba
{
    public partial class Form2 : Form
    {
        // Pendeklarasian Variabel
        public string nama_war;
        public string invest_war;
        public string bahan_war;
        public string bahan_sat;
        public string opra_sat;
        public string karyawan_war;
        public string lokasi_war;
        public string harga_pro;
        public string penjualan_sat;
        public string jumlah_pro;
        public string bahan_pil_sat;

        public int Total_Modal;
        public int invest__war;
        public int bahan__war;
        public int Total_Pendapatan;
        public int Laba_Bersih;
        public int Laba_Prediksi;
        public int operasional;
        public int karyawan__war;
        public int lokasi__war;
        public int harga__pro;
        public int Bulan_Kembali;
        public int jumlah__pro;
        public int i;
        public double Presentasi_Profit;
        public double d;
        public Form2()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Pengambilan nilai dari Form1 dengan getter
            nama_war= Form1.war_nama() ;
            invest_war= Form1.war_invest() ;
            bahan_war= Form1.war_bahan() ;
            bahan_sat= Form1.sat_bahan() ;
            opra_sat= Form1.sat_opra() ; 
            karyawan_war= Form1.war_karyawan() ;
            lokasi_war= Form1.war_lokasi() ;
            harga_pro= Form1.pro_harga() ;
            penjualan_sat= Form1.sat_penjualan() ; 
            jumlah_pro= Form1.pro_jumlah() ;
            bahan_pil_sat = Form1.sat_pil_bahan();

            //nama__war = int.Parse(nama_war);
            invest__war = int.Parse(invest_war);
            bahan__war = int.Parse(bahan_war);
            //bahan__sat = int.Parse(bahan_sat);
            //opra__sat = int.Parse(opra_sat);
            karyawan__war = int.Parse(karyawan_war);
            lokasi__war = int.Parse(lokasi_war);
            harga__pro = int.Parse(harga_pro);
            //penjualan__sat = int.Parse(penjualan_sat);
            jumlah__pro = int.Parse(jumlah_pro);

            // Pengolahan Nilai
            label3.Text = nama_war;
            label5.Text = "Rp. "+invest_war;
            if (bahan_pil_sat == "Total")
            {
                if (bahan_sat == "Bulan")
                {
                    label9.Text = "Rp. " + bahan_war + " / Bulan";
                }
                else
                {
                    bahan__war = bahan__war * 30;
                    label9.Text = "Rp. " + Convert.ToString(bahan__war) + " / Bulan";
                }
            }
            else 
            {
                if (bahan_sat == "Bulan")
                {
                    bahan__war = bahan__war * jumlah__pro;
                    label9.Text = "Rp. " + Convert.ToString(bahan__war) + " / Bulan";
                }
                else
                {
                    bahan__war = bahan__war * 30 * jumlah__pro;
                    label9.Text = "Rp. " + Convert.ToString(bahan__war) + " / Bulan";
                }
            }

            if (opra_sat == "Bulan")
            {
                operasional = karyawan__war + lokasi__war;
                label10.Text = "Rp. " + Convert.ToString(operasional) + " / Bulan";
            }
            else 
            {
                operasional = karyawan__war + lokasi__war;
                operasional = operasional * 30;
                label10.Text = "Rp. " + Convert.ToString(operasional) + " / Bulan";
            }

            Total_Modal = bahan__war + operasional;
            label12.Text = "Rp. " + Convert.ToString(Total_Modal);


            label16.Text = "Rp. " + harga_pro + " / pcs";
            if (penjualan_sat == "Bulan")
            {
                label15.Text = jumlah_pro + "  pcs / Bulan";
            }
            else
            {
                jumlah__pro = jumlah__pro * 30;
                label15.Text =Convert.ToString(jumlah__pro) + "  pcs / Bulan";
            }

            Total_Pendapatan = harga__pro * jumlah__pro;
            label14.Text = "Rp. " + Convert.ToString(Total_Pendapatan);


            label23.Text = "Rp. " + Convert.ToString(Total_Pendapatan) + " / Bulan";
            label22.Text = "Rp. " + Convert.ToString(Total_Modal) + " / Bulan";
            Laba_Bersih = Total_Pendapatan - Total_Modal;
            label21.Text = "Rp. " + Convert.ToString(Laba_Bersih);

            if (Laba_Bersih > 0)
            {
                Presentasi_Profit = double.Parse(Convert.ToString(Laba_Bersih)) / double.Parse(Convert.ToString(Total_Modal)) * 100;
                d = Math.Round(Presentasi_Profit, 2);
                label27.Text = "PROFIT : " + Convert.ToString(d) + " %";
            }
            else 
            {
                label27.Text = "PROFIT : " + Convert.ToString(0) + " % (RUGI)";
            }
            

            if (Laba_Bersih > 0)
            {
                i = 1;
                Bulan_Kembali = 1;
                Laba_Prediksi = Laba_Bersih;
                while (i > 0)
                {
                    if (Laba_Prediksi >= invest__war)
                    {
                        label28.Text = "B.E.P : " + Convert.ToString(Bulan_Kembali) + " BULAN";
                        break;
                    }
                    else
                    {
                        Laba_Prediksi = Laba_Prediksi + Laba_Bersih;
                        Bulan_Kembali += 1;
                    }
                }
            }
            else 
            {
                label28.Text = "B.E.P : ~";
            }

            if (Bulan_Kembali <= 5 && Bulan_Kembali > 0)
            {
                this.textBox1.Text = "Hasil Memuaskan";
            }
            else if (Bulan_Kembali > 5)
            {
                this.textBox1.Text = "Coba Pikirkan Kembali";
            }
            else 
            {
                this.textBox1.Text = "Anda Merugi";
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
