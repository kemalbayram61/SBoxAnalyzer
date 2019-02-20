using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SboxSifreleme
{
    class DPf
    {
        Numpy np = new Numpy();
        int m = 8;
        int n = 8;
        int[,] count,maxi,dbox;

        public int[,] dpfHesapla(int [] s)
        {
            count = np.Zeros(Convert.ToInt32(Math.Pow(2, m)), Convert.ToInt32(Math.Pow(2, n)));
            //diferansiyel dağıtım tablosunu 2 ** m* 2 ** n büyüklüğünde üretin
            for (int a = 1; a < Convert.ToInt32(Math.Pow(2, m)); a++)
            {
                for (int b = 0; b < Convert.ToInt32(Math.Pow(2, n)); b++)
                {
                    for (int x = 0; x < Convert.ToInt32(Math.Pow(2, m)); x++)
                    {
                        if ((s[x] ^ s[x ^ a]) == b)
                        {
                            count[a, b] = count[a, b] + 1;
                        }
                    }
                }
            }

            //Bir delta x için, tüm deltaların maksimumlarını alın ve diferansiyel dağılımın değerlerini yaratın.

            maxi = np.Zeros(Convert.ToInt32(Math.Pow(2, m)));
            for (int a = 1; a < Convert.ToInt32(Math.Pow(2, m)); a++)
            {
                for (int b = 0; b < Convert.ToInt32(Math.Pow(2, n)); b++)
                {
                    if (maxi[a - 1, 0] < count[a, b])
                    {
                        maxi[a - 1, 0] = count[a, b];
                    }
                }
            }

            //değerleri 16 * 16 bir tabloya koyun, böylece giriş / çıkış XOR dağılımı elde edilir.
            dbox = np.Zeros(16, 16);
            for(int i = 0; i < 16; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    dbox[i, j] = maxi[16 * i + j,0];
                }
            }
            return dbox;
        }
    }
}
