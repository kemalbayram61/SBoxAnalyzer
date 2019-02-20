using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SboxSifreleme
{
    class Nonlinearity
    {
        Numpy np = new Numpy();
        int m = 8, n = 8;
        public int dianji(int x,int y)
        {
            int[] r=new int[m];
            int[] t=new int[m];
            int z = 0;
            for(int i = 0; i < m; i++)
            {
                r[i] = ((x >> i) & 1);
                t[i] = ((y >> i) & 1);
                z = z ^ (r[i] * t[i]);
            }
            return z;
        }
        public int[,] nonLinearity(int[] s)
        {
            int[,] sf = np.Zeros(n,Convert.ToInt32(Math.Pow(2,m)));
            int[,] maxsf = np.Zeros(n);
            int[,] nf = np.Zeros(n);

            //Denklem ile Walsh spektrumunu hesaplar.
            for(int i = 0; i < n; i++)
            {
                for(int w = 0; w < Convert.ToInt32(Math.Pow(2, m)); w++)
                {
                    for (int x = 0; x < Convert.ToInt32(Math.Pow(2, m)); x++)
                    {
                        sf[i,w] =Convert.ToInt32(Math.Pow(sf[i,w] + (-1) ,(((s[x] >> i) & 1) ^ (dianji(x, w)))));
                    }
                }
            }

            //Walsh spektrumu ile tarif edilen doğrusal olmayan Nf'yi hesaplar.
            for (int i = 0; i < n; i++)
            {
                for (int w = 0; w < Convert.ToInt32(Math.Pow(2, m)); w++)
                {
                    if (maxsf[i, 0] < Math.Abs(sf[i, w]))
                    {
                        maxsf[i, 0] = Math.Abs(sf[i, w]);
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                nf[i, 0] = Convert.ToInt32(Math.Pow(2, m - 1) * Math.Pow(2, -m) * maxsf[i, 0]);
            }
            return nf;
        }
    }
}
