using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinası
{
    public partial class hesapmakinesi : Form

    {
        private char _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;
       


        public hesapmakinesi()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text=="0")
            {
                ekranLabel.Text = "";
              
            }
            ekranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi )
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;

            }

                if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "0";
        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);


        }

        private void eşittirbutton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
             
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void çarpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bölmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void silmebutton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
