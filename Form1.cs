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
    public partial class Form1 : Form
    {
        // Pendeklarasian variabel
        public static string nama_war;
        public static string invest_war;
        public static string bahan_war;
        public static string bahan_sat;
        public static string opra_sat; 
        public static string karyawan_war;
        public static string lokasi_war;
        public static string harga_pro;
        public static string penjualan_sat; 
        public static string jumlah_pro;
        public static string bahan_pil_sat;
        public int ms;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Form3 frm3 = new Form3();
            frm3.ShowDialog();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ms = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ms++;

            if (ms % 2 == 0)
            {
                if (comboBox4.Text == "Total")
                {
                    comboBox1.Enabled = true;
                }
                else
                {
                    comboBox1.Enabled = false;

                    if (comboBox2.Text == "Bulan")
                    {
                        comboBox1.Text = "Bulan";
                    }
                    else
                    {
                        comboBox1.Text = "Hari";
                    }
                }

               

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Pengecekan apakah kotak input telah terisisemua
            int sal = 0;

            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }
            else 
            {
                nama_war = this.textBox1.Text;
                sal = sal + 1;
            }

            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                invest_war = this.textBox2.Text;
                sal = sal + 1;
            }

            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                bahan_war = this.textBox3.Text;
                sal = sal + 1;
            }
            
            bahan_sat = this.comboBox1.Text;
            bahan_pil_sat = this.comboBox4.Text;
            opra_sat = this.comboBox3.Text;

            // Proses kotak berwarna merah apa bila belum diisi
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
            }
            else
            {
                karyawan_war = this.textBox4.Text;
                sal = sal + 1;
            }

            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.Red;
            }
            else
            {
                lokasi_war = this.textBox5.Text;
                sal = sal + 1;
            }

            if (textBox6.Text == "")
            {
                textBox6.BackColor = Color.Red;
            }
            else
            {
                harga_pro = this.textBox6.Text;
                sal = sal + 1;
            }
            
            penjualan_sat = this.comboBox2.Text;

            if (textBox7.Text == "")
            {
                textBox7.BackColor = Color.Red;
            }
            else
            {
                jumlah_pro = this.textBox7.Text;
                sal = sal + 1;
            }



            if (sal == 7)
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
           
        }

        // Method getter untuk semua Variabel
        public static string sat_pil_bahan() 
        {
            return bahan_pil_sat;
        }

        public static string war_nama() 
        {
            return nama_war;
        }
        public static string war_invest()
        {
            return invest_war;
        }
        public static string war_bahan()
        {
            return bahan_war;
        }
        public static string sat_bahan()
        {
            return bahan_sat;
        }
        public static string sat_opra()
        {
            return opra_sat;
        }
        public static string war_karyawan()
        {
            return karyawan_war;
        }
        public static string war_lokasi()
        {
            return lokasi_war;
        }
        public static string pro_harga()
        {
            return harga_pro;
        }
        public static string sat_penjualan()
        {
            return penjualan_sat;
        }
        public static string pro_jumlah()
        {
            return jumlah_pro;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fungsi Tombol Clear untuk menghapus kotak isian
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }     
    }
}
