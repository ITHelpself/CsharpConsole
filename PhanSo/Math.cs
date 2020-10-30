using System;
using System.Collections.Generic;
using System.Text;

namespace PhanSo
{
    public partial class Math
    {
        public static int USCLN(int a, int b)
        {
            int uscln = 1;
            // 3 6 --> usc = 3,6
            int max, min;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            for(int i = min; i > 1; i--)
            {
                if(max%i == 0 && min %i == 0)
                {
                    uscln = i;
                    break;
                }
            }
            return uscln;
        }
    }
}
