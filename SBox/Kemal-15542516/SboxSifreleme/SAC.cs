using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SboxSifreleme
{
    class SAC
    {
        Numpy np = new Numpy();
        int m = 8, n = 8;
        int[] c;
        public int[,] y, z;
        public int maxy = 0,suma=0,miny=255;

        public void sac(int[] s)
        {
            y = np.Zeros(n, m);
            z = np.Zeros(n, m);
            c = new int[m];
            int v;
            for(int i = 0; i < m; i++)
            {
                c[i] = Convert.ToInt32(Math.Pow(2, i));
            }
            for(int x = 0; x < Convert.ToInt32(Math.Pow(2, m)); x++)
            {
                for(int j = 0; j < m; j++)
                {
                    v = s[x] ^ s[x ^ c[j]];
                    for(int i = 0; i < n; i++)
                    {
                        y[i, j] = y[i, j] + ((v >> i) & 1);
                    }
                }
            }
            
            //Bağımlılık matrisindeki her elemanı hesaplar.
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    z[i, j] =Convert.ToInt32(Math.Round(y[i, j] / Math.Pow(2, m), 4));
                }
            }

            // Bağımlılık matrisinde Maksimum, Minimum ve Ortalama değerini hesaplar.
            
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    if (maxy < y[i, j])
                    {
                        maxy = y[i, j];
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (miny > y[i, j])
                    {
                        miny = y[i, j];
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    suma += y[i, j];
                }
            }
            maxy = Convert.ToInt32(Math.Round(maxy / Math.Pow(2, m), 4));
            miny = Convert.ToInt32(Math.Round(miny / Math.Pow(2, m), 4));
            suma = Convert.ToInt32(Math.Round(suma / Math.Pow(2,m)*m*n,4));
        }
    }
}
