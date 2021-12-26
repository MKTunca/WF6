using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class musteri_islemleri : Form
    {
        public musteri_islemleri()
        {
            InitializeComponent();
        }
        musteriler mus = new musteriler();
        List<musteriler> musterilistesi = new List<musteriler>();
        int x = 4;
        private void Form1_Load(object sender, EventArgs e)
        {
            musterilistesi.Add(new musteriler
            {
                musteriID = 1,
                musteriTC = "30209243878",
                musteriAS = "mustafa tunca",
                musteriDY = 1997
            });
            musterilistesi.Add(new musteriler
            {
                musteriID = 2,
                musteriTC = "30209243879",
                musteriAS = "turgay tunca",
                musteriDY = 1969
            });
            musterilistesi.Add(new musteriler
            {
                musteriID = 3,
                musteriTC = "30209243880",
                musteriAS = "tuğrul tunca",
                musteriDY = 2003
            });
            dgv.DataSource = musterilistesi.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((ID.Text != "") && (TC.Text != "") && (AS.Text != "") && (DY.Text != ""))
            {
                musterilistesi.Add(new musteriler
                {
                    musteriID = Convert.ToInt32(ID.Text),
                    musteriTC = TC.Text,
                    musteriAS = AS.Text,
                    musteriDY = Convert.ToInt32(DY.Text)
                });
                x++;
                dgv.DataSource = musterilistesi.ToList();
                ID.Text = x.ToString();
                TC.Text = "";
                AS.Text = "";
                DY.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteri_islemleri mi = new musteri_islemleri();
            mi.ShowDialog();
        }

        private void DY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar>=48&&(int)e.KeyChar<=57)
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar>=65&&(int)e.KeyChar<=90)
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar>=97&&(int)e.KeyChar<=122)
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar==32)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
