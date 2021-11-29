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


namespace P4_4_1204004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No. Telp : " + tbnum.Text + "\nNama : " + tbchar.Text + "\nEmail : " + tbregex.Text + "\nPerbandingan : " + tbcom1.Text + " " + tbcom2.Text + "\nPassword : " + tbleng.Text + "\nNama dalam UPPERCASE : " + tbupper.Text + "\nusername dalam lowercase : " + tblower.Text);

        }

        private void tbnum_Leave(object sender, EventArgs e)
        {
            int tbnumval;
            if (int.TryParse(tbnum.Text, out tbnumval))
            {
                epbenar.SetError(tbnum, "OK");
            }

            else if (tbnum.Text == "")
            {
                epwarn.SetError(tbnum, "Data tidak boleh kosong");
            }

            else
            {
                epsalah.SetError(tbnum, "Silahkan Diisi");
            }

        }

        private void tbchar_Leave(object sender, EventArgs e)
        {
 
            if (tbchar.Text != "")
            {
                epbenar.SetError(tbchar, "Nice!");
            }

            else if (tbchar.Text == "")
            {
                epwarn.SetError(tbchar, "Data tidak boleh kosong");
            }

            else
            {
                epsalah.SetError(tbchar, "Silahkan Isi Nama Anda");
            }
        }

        private void tbregex_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbregex.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epbenar.SetError(tbregex, "Betul!");
            }

            else if (tbregex.Text == "")
            {
                epwarn.SetError(tbregex, "Data tidak boleh kosong");
            }

            else
            {
                epsalah.SetError(tbregex, "Format salah !\nContoh: a@b.c");
            }
        }

        private void tbcom1_Leave(object sender, EventArgs e)
        {
            if ((tbcom1.Text).All(Char.IsNumber))
            {
                epbenar.SetError(tbcom1, "Betul");
            }

            else if (tbcom1.Text == "")
            {
                epwarn.SetError(tbcom1, "Data tidak boleh kosong");

            }

            else
            {
                epsalah.SetError(tbcom1, "Inputan hanya boleh Angka!");
            }
        }

        private void tbcom2_Leave(object sender, EventArgs e)
        {
            if ((tbcom2.Text).All(Char.IsNumber))
            {
                int Angka1;
                int Angka2;
                int.TryParse(tbcom1.Text, out Angka1);
                int.TryParse(tbcom2.Text, out Angka2);
                if (Angka1 > Angka2)
                {
                    epbenar.SetError(tbcom1, "Angka 1 lebih besar dari angka 2 ");
                    epwarn.SetError(tbcom2, "Angka 2 lebih kecil dari angka 1 ");
                }

                else
                {
                    epbenar.SetError(tbcom2, "Angka 2 lebih besar dari angka 1 ");
                    epwarn.SetError(tbcom1, "Angka 1 lebih kecil dari angka 2 ");
                }
            }

            else if (tbcom2.Text == "")
            {
                epwarn.SetError(tbcom2, "Data tidak boleh kosong");

            }

            else
            {
                epsalah.SetError(tbcom2, "inputan hanya boleh Angka!");
            }
        }

        private void tbleng_Leave(object sender, EventArgs e)
        {
            if (tbleng.Text != "")
            {
                int length = tbleng.Text.Length;
                if (length > 7)
                {
                    epbenar.SetError(tbleng, "Password Benar");
                }
                else
                {
                    epsalah.SetError(tbleng, "Password Salah");
                }
                
            }
            else
            {
                epwarn.SetError(tbleng, "Silahkan Diisi");
            }
        }

        private void tbupper_Leave(object sender, EventArgs e)
        {
            if (tbupper.Text.All(char.IsUpper))
            {
                epbenar.SetError(tbupper, "Sesuai");
            }

            else if (tbupper.Text == "")
            {
                epwarn.SetError(tbupper, "Gunakanlah huruf kapital");
            }

            else
            {
                epsalah.SetError(tbupper, "Bukan Kapital");
            }
        }

        private void tblower_Leave(object sender, EventArgs e)
        {
            if (tblower.Text.All(char.IsLower))
            {
                epbenar.SetError(tblower, "OK");
            }

            else if (tblower.Text == "")
            {
                epwarn.SetError(tblower, "Gunakanlah huruf kecil");
            }

            else
            {
                epsalah.SetError(tblower, "Bukan huruf kecil");
            }
        }
    }
}
