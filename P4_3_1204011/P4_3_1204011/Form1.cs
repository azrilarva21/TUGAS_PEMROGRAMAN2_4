using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void huruf_Leave(object sender, EventArgs e)
        {
            if (huruf.Text == "")
            {
                epWarning.SetError(huruf, "Textbox Huruf tidak boleh kosong");

            }
            else
            {
                if ((huruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(huruf, "");
                    epWrong.SetError(huruf, "");
                    epCorrect.SetError(huruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(huruf, "inputan hanya boleh huruf!");
                    epWarning.SetError(huruf, "");
                    epCorrect.SetError(huruf, "");
                }
            }
        }

        private void angka_Leave(object sender, EventArgs e)
        {
            if ((angka.Text).All(Char.IsNumber))
            {
                epWarning.SetError(angka, "");
                epWrong.SetError(angka, "");
                epCorrect.SetError(angka, "Betul!");
            }

            else if (angka.Text == "")
            {
                epWarning.SetError(angka, "Textbox Huruf tidak boleh kosong");
            }

            else
            {
                epWrong.SetError(angka, "inputan hanya boleh Angka!");
                epWarning.SetError(angka, "");
                epCorrect.SetError(angka, "");
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(email, "");
                epWrong.SetError(email, "");
                epCorrect.SetError(email, "Betul!");
            }

            else if (email.Text == "")
            {
                epWarning.SetError(email, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(email, "Format email salah !\nContoh: a@b.c");
                epWarning.SetError(email, "");
                epCorrect.SetError(email, "");
            }
        }

        private void angka1_Leave(object sender, EventArgs e)
        {
            if ((angka1.Text).All(Char.IsNumber))
            {
                if (angka2.Text == "")
                {
                    epWarning.SetError(angka1, "Angka 2 Belum terisi");
                }

                else
                {
                    epCorrect.SetError(angka1, "Angka 2 Terisi");
                }
            }

            else if (angka1.Text == "")
            {
                epWarning.SetError(angka1, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(angka1, "inputan hanya boleh Angka!");
            }
        }

        private void angka2_Leave(object sender, EventArgs e)
        {
            if ((angka2.Text).All(Char.IsNumber))
            {
                int Angka1 = int.Parse(angka1.Text);
                int Angka2 = int.Parse(angka2.Text);
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(angka2, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((angka2.Text == ""))
            {
                epWarning.SetError(angka2, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(angka2, "inputan hanya boleh Angka!");
            }
        }
    }
}
