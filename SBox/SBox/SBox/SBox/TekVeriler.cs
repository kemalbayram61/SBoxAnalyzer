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
    public partial class TekVeriler : Form
    {
        BIC_Nonlinearty bicNonlinear = new BIC_Nonlinearty();
        BIC_SAC bicSac = new BIC_SAC();
        DPF dpf = new DPF();
        Nonlinearty nonlinearity = new Nonlinearty();
        SAC sac = new SAC();
        DiziIslem diziIslem = new DiziIslem();
        public int[] sBox;
        public int m = 8;
        public int n = 8;
        public double nonAvg,bicsac,bicnon,sacAvg,sacMin,sacMax;
        public int nonMin,nonMax;
        public TekVeriler()
        {
            InitializeComponent();
            this.sBox = anaForm.sBox;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TekVeriler_Load(object sender, EventArgs e)
        {
            //DPF sınıfı
            int[,] dpBox = dpf.Dpfmodul(n, m, sBox);
            txtMaximumio.Text = diziIslem.MatrisEnBuyuk(dpBox).ToString();//dpBox yansıtma

            //Nonlinearity sınıfı
            int[] nonlinearDizi=nonlinearity.nonlinear(m, n, sBox);
            txtNAvg.Text = diziIslem.diziOrtalama(nonlinearDizi).ToString("f6");
            txtNMax.Text = diziIslem.diziEnbuyuk(nonlinearDizi).ToString();
            txtNMin.Text = diziIslem.diziEnkucuk(nonlinearDizi).ToString();

            //SAC Sınıfı
            sac.sac(n, m, sBox);
            sacMin = sac.miny;
            sacMax = sac.maxy;
            sacAvg = sac.suma;
            txtSAvg.Text =sacAvg.ToString("f6");
            txtSMax.Text = sacMax.ToString("f6");
            txtSMin.Text = sacMin.ToString("f6");

            //Bic Sac Sınıfı
            double bicsacSonuc = bicSac.BicSac(sBox, n, m);
            txtBicsac.Text = bicsacSonuc.ToString();

            //Bic Nonlinearity
            double[,] bicnonlinearSonuc = bicNonlinear.Walsh(m, n, sBox);
            txtBicnon.Text = diziIslem.matrisOrtalama(bicnonlinearSonuc).ToString("f6");
        }
    }
}
