using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesilast
{
    public partial class Form1 : Form

    {

        private char _islem;
        private bool _Ekrantemizlenecekmi;
        private int _ilksayı;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }

            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "4";


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "8";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_Ekrantemizlenecekmi)
            {

                lblEkran.Text = "";
                _Ekrantemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "9";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _Ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(lblEkran.Text);
        }

        private void btnEsit_Click(object sender, EventArgs e)
        {
            try
            {



                int ikincisayi = Convert.ToInt32(lblEkran.Text);
                int sonuc = _islem;

                switch (_islem)
                {

                    case '+':
                        sonuc = _ilksayı + ikincisayi;
                        break;
                    case '-':
                        sonuc = _ilksayı - ikincisayi;
                        break;
                    case '*':
                        sonuc = _ilksayı * ikincisayi;
                        break;
                    case '/':
                        sonuc = _ilksayı / ikincisayi;
                        break;
                }
                lblEkran.Text = Convert.ToString(sonuc);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _Ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(lblEkran.Text);
            MessageBox.Show("Çıkarma İşlemi Yapıyorsunuz Onaylıyormusunuz ? ","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnÇarp_Click(object sender, EventArgs e)
        {
            try
            {


                _islem = '*';
                _Ekrantemizlenecekmi = true;
                _ilksayı = Convert.ToInt32(lblEkran.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBöl_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _Ekrantemizlenecekmi = true;
            _ilksayı = Convert.ToInt32(lblEkran.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";

        }
    }
}
