using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator___Jovan_Dragas
{
    class Rimski
    {
        static string prviR;
        static string drugiR;
        static char operacijaR;
        static char x;
        public void ac()
        {
            prviR = "";
        }
        public int prepoznajR(string a)
        {
            char[] operacije = { '+', '-', 'x', '/' }; int i = 0;
            prviR = rezR(); drugiR = "";
            if (prviR == "")
            {
                while (!operacije.Contains(a[i]))
                {
                    prviR += a[i]; i++;
                }
            }
            else
            {
                i += prviR.Length;
            }
            operacijaR = a[i]; i++;
            while (i < a.Length)
            {
                drugiR += a[i]; i++;
            }
            if (operacijaR == Convert.ToChar("+")) { x = '+'; }
            if (operacijaR == Convert.ToChar("-")) { x = '-'; }
            if (operacijaR == Convert.ToChar("x")) { x = 'x'; }
            if (operacijaR == Convert.ToChar("/")) { x = '/'; }
            return 0;
        }
        private int toInt(char a)
        {
            List<KeyValuePair<char, int>> vrednost = new List<KeyValuePair<char, int>>
            {
                new KeyValuePair<char, int> ('I', 1),
                new KeyValuePair<char, int> ('V', 5),
                new KeyValuePair<char, int> ('X', 10),
                new KeyValuePair<char, int> ('L', 50),
                new KeyValuePair<char, int> ('C', 100),
                new KeyValuePair<char, int> ('D', 500),
                new KeyValuePair<char, int> ('M', 1000),
            };
            return vrednost.SingleOrDefault(s => s.Key == a).Value;
        }
        public int prviRInt()
        {
            int z = 0;
            char[] slova = prviR.ToArray();
            for (int i =0; i < slova.Length; i++)
            {
                int value1 = toInt(slova[i]);
                if (i + 1 < slova.Length)
                {
                    int value2 = toInt(slova[i + 1]);
                    if (value1 >= value2)
                    {
                        z += value1;
                    }
                    else
                    {
                        z += value2 - value1;
                        i += 1;
                    }
                }
                else
                {
                    z += value1;
                }
            }
            return z;
        }

        public int drugiRInt()
        {
            int z = 0;
            char[] slova = drugiR.ToArray();
            for (int i = 0; i < slova.Length; i++)
            {
                int value1 = toInt(slova[i]);
                if (i + 1 < slova.Length)
                {
                    int value2 = toInt(slova[i + 1]);
                    if (value1 >= value2)
                    {
                        z += value1;
                    }
                    else
                    {
                        z += value2 - value1;
                        i += 1;
                    }
                }
                else
                {
                    z += value1;
                }
            }
            return z;
        }

        public string toRim(int a)
        {
            string s = "";
            while (a > 0) 
            {
                if (a > 1000) { s += 'M'; a -= 1000; }
                else if (a >= 900) { s += "CM"; a -= 900; }
                else if (a >= 500) { s += 'D'; a -= 500; }
                else if (a >= 400) { s += "CD"; a -= 400; }
                else if (a >= 100) { s += 'C'; a -= 100; }
                else if (a >= 90) { s += "XC"; a -= 90; }
                else if (a >= 50) { s += 'L'; a -= 50; }
                else if (a >= 40) { s += "XL"; a -= 40; }
                else if (a >= 10) { s += 'X'; a -= 10; }
                else if (a >= 9) { s += "IX"; a -= 9; }
                else if (a >= 5) { s += 'V'; a -= 5; }
                else if (a >= 4) { s += "IV"; a -= 4; }
                else if (a >= 1) { s += 'I'; a -= 1; }
            }
            return s;
        }
        public string rezR()
        {
            int z = 0;
            if (x == '+') { z = prviRInt() + drugiRInt(); }
            if (x == '-') { z = prviRInt() - drugiRInt(); }
            if (x == 'x') { z = prviRInt() * drugiRInt(); }
            if (x == '/') { z = prviRInt() / drugiRInt(); }
            return toRim(z);
        }
    }
}
