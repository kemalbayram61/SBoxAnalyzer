using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBox
{
    class DiziIslem
    {
        public int[] InteCevir(string metin)
        {
            string[] parcali = metin.Split(',');
            int[] dizi = new int[parcali.Length];
            for(int i = 0; i < parcali.Length; i++)
            {
                dizi[i] =Convert.ToInt32(parcali[i]);
            }
            return dizi;
        }
        public string StringeCevir(int[] dizi)
        {
            string sonuc = "";
            for(int i = 0; i < dizi.Length; i++)
            {
                sonuc += dizi[i] + "\t";
                if (i % 8 == 0) sonuc += "\n";
            }
            return sonuc;
        }
        public int MatrisEnBuyuk(int[,] Matris)
        {
            int enb = int.MinValue;
            for(int i = 0; i < Matris.GetLength(0); i++)
            {
                for(int j = 0; j < Matris.GetLength(1); j++)
                {
                    if (enb < Matris[i, j]) enb = Matris[i, j];
                }
            }
            return enb;
        }
        public int diziEnbuyuk(int[] dizi)
        {
            int enb = int.MinValue;
            for(int i = 0; i < dizi.Length; i++)
            {
                if (enb < dizi[i]) enb = dizi[i];
            }
            return enb;
        }
        public int diziEnkucuk(int[] dizi)
        {
            int enk = int.MaxValue;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enk > dizi[i]) enk = dizi[i];
            }
            return enk;
        }
        public double diziOrtalama(int[] dizi)
        {
            double sonuc = 0.00000;
            for (int i = 0; i < dizi.Length; i++)
            {
                sonuc += (double)dizi[i] / dizi.Length;
            }
            return sonuc;
        }
        public double matrisOrtalama(double[,] Matris)
        {
            double ortalama=0;
            for (int i = 0; i < Matris.GetLength(0); i++)
            {
                for (int j = 0; j < Matris.GetLength(1); j++)
                {
                    ortalama += (double)Matris[i, j] / (Matris.GetLength(0) * Matris.GetLength(1));
                }
            }
            return ortalama;
        }
    }
}
