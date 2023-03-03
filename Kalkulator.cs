using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator___Jovan_Dragas
{
    class Kalkulator
    {
        static string prvi;
        static string drugi;
        static char operacija;

        public int prepoznaj(string a)
        {
            string[] operacije = { "+", "-", "x", "/" }; int i = 0;
            prvi = rez(); drugi = ""; operacija = Convert.ToChar("");
            if (a[i] == Convert.ToChar("("))
            {
                while (a[i] != Convert.ToChar(")"))
                {
                    prvi += a[i]; i++;
                }
                prvi += ")"; i++;
            }
            else
            {
                while (a[i] != Convert.ToChar(operacije))
                {
                    prvi += a[i]; i++;
                }
            }

            operacija = a[i]; i++;

            if (a[i] == Convert.ToChar("("))
            {
                while (a[i] != Convert.ToChar(")"))
                {
                    drugi += a[i]; i++;
                }
                drugi += ")"; i++;
            }
            else
            {
                while (a[i] != Convert.ToChar(operacije))
                {
                    prvi += a[i]; i++;
                }
            }

            if (operacija == Convert.ToChar("+")) { return 1; }
            if (operacija == Convert.ToChar("-")) { return 2; }
            if (operacija == Convert.ToChar("x")) { return 3; }
            if (operacija == Convert.ToChar("/")) { return 4; }
            else return 0;
        }
        public int broj1Vrsta()
        {
            for (int i = 0; i < prvi.Length; i++)
            {
                if (prvi[i] == Convert.ToChar("i")) { return 1; }
            }
            return 0;
        }
        public int broj2Vrsta()
        {
            for (int i = 0; i < drugi.Length; i++)
            {
                if (drugi[i] == Convert.ToChar("i")) { return 1; }
            }
            return 0;
        }
        public string rez()
        {
            return "pivo";
        }
    }
}
