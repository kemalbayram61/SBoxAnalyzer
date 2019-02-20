using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBox
{
    class DPF
    {
        public void matrisYaz(int[,] sf)
        {
            Console.WriteLine();
            for (int i = 0; i < sf.GetLength(0); i++)
            {
                for (int l = 0; l < sf.GetLength(1); l++) Console.Write(sf[i, l] + "  ");
                Console.WriteLine();
            }
        }
        public int[,] Dpfmodul(int n, int m, int[] s)
        {
            int[,] count = new int[(int)Math.Pow(2, m), (int)Math.Pow(2, n)];
            for (int a = 1; a < Math.Pow(2, m); a++)
            {
                for (int b = 0; b < Math.Pow(2, n); b++)
                {
                    for (int x = 0; x < Math.Pow(2, m); x++)
                    {
                        if ((s[x] ^ s[x ^ a]) == b) count[a, b] = count[a, b] + 1;
                    }
                }
            }
            int[] maxi = new int[(int)Math.Pow(2, m)];
            for (int a = 1; a < Math.Pow(2, m); a++)
            {
                for (int b = 0; b < Math.Pow(2, n); b++)
                {
                    if (maxi[a - 1] < count[a, b]) maxi[a - 1] = count[a, b];
                }
            }
            int[,] dpbox = new int[16, 16];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    dpbox[i, j] = maxi[16 * i + j];
                }
            }
            return dpbox;
        }
    }
}
