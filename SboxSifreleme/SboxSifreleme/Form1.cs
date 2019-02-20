using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SboxSifreleme
{
    public partial class Form1 : Form
    {
        int[] s;
        int[] dizi;
        public Form1()
        {
            InitializeComponent();
        }
        public void txtYazdir(int[,] matris)
        {
            txtGirdi.Text = "";
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    txtGirdi.Text += matris[i, j]+"\t";
                }
                txtGirdi.Text += "\n";
            }
        }
        public void diziYaz()
        {
            txtGirdi.Text = "";
            for(int i = 0; i < dizi.Length; i++)
            {
                if (i % 10 == 0) txtGirdi.Text += "\n";
                txtGirdi.Text += dizi[i].ToString()+"\t";
            }
        }
        public void diziyiYorumla()
        {
            if (txtGirdi.Text != "")
            {
                string[] parcali = txtGirdi.Text.Split(',');
                dizi = new int[parcali.Length];
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = Convert.ToInt32(parcali[i]);
                }
                s = dizi;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnBic_Click(object sender, EventArgs e)
        {
            BIC_nonlinearity bicnon = new BIC_nonlinearity();
            int[,] bicnonmat = bicnon.walsSpektrumu(s);
            txtYazdir(bicnonmat);
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            BIG_SAC bicsac = new BIG_SAC();
            double bicsacdeger = bicsac.bigSac(s);
            txtGirdi.Text = "";
            txtGirdi.Text = bicsacdeger.ToString();
        }

        private void btnDpf_Click(object sender, EventArgs e)
        {
            DPf dpf = new DPf();
            int[,] dpfhesap = dpf.dpfHesapla(s);
            txtYazdir(dpfhesap);
        }

        private void btnNonlin_Click(object sender, EventArgs e)
        {
            Nonlinearity nonlinear = new Nonlinearity();
            int[,] nonlinearhesap = nonlinear.nonLinearity(s);
            txtYazdir(nonlinearhesap);
        }

        private void btnDizial_Click(object sender, EventArgs e)
        {
            diziyiYorumla();
            diziYaz();
            btnBic.Enabled = true;
            btnBig.Enabled = true;
            btnDpf.Enabled = true;
            btnNonlin.Enabled = true;
        }
    }
}
