using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator___Jovan_Dragas
{
    class Long
    {
        public long VrLong()
        {
            string a = textBox1.Text;
            int x = 1;
            long br = 0;
            for (int i = 0; i < a.Length; i++)
            {
                br = br + Convert.ToInt32(a[a.Length - i]) * x;
                x = x * 10;
            }
            return br;
        }
    }
}
