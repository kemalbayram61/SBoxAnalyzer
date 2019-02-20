using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBox
{
    public partial class anaForm : Form
    {
        DiziIslem diziIslem = new DiziIslem();
        public static int[] sBox;
        public anaForm()
        {
            InitializeComponent();
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            TekVeriler frm = new TekVeriler();
            frm.Show();
        }

        private void btnYorumla_Click(object sender, EventArgs e)
        {
            sBox = diziIslem.InteCevir(txtSbox.Text);
            txtSbox.Text = diziIslem.StringeCevir(sBox);
            btnSonuclar.Enabled = true;
            btnYorumla.Enabled = false;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
