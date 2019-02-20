using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBox
{
    class Nonlinearty
    {
        BIC_Nonlinearty bicnon = new BIC_Nonlinearty();
        public int[] nonlinear(int m, int n, int[] s)
        {
            int[] nf = new int[n];
            int[,] sf = new int[n, (int)Math.Pow(2, m)];
            int[] maxsf = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int w = 0; w < Math.Pow(2, m); w++)
                {
                    for (int x = 0; x < Math.Pow(2, m); x++)
                    {
                        sf[i, w] = sf[i, w] + (int)Math.Pow(-1, ((s[x] >> i) & 1) ^ (bicnon.dianji(x, w, m)));
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int w = 0; w < Math.Pow(2, m); w++)
                {
                    if (maxsf[i] < Math.Abs(sf[i, w]))
                    {
                        maxsf[i] = Math.Abs(sf[i, w]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                nf[i] = (int)(Math.Pow(2, m - 1) * (1 - Math.Pow(2, -m) * maxsf[i]));
            }
            return nf;
        }
    }
}
