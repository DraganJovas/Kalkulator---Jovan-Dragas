using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator___Jovan_Dragas
{
    class Kompleksni
    {
        static string prviK;
        static string drugiK;
        static char operacijaK;
        char[] operacije = { '+', '-', 'x', '/' };
        public int prepoznajK(string a)
        {
            int i = 0;
            prviK = rezK(); drugiK = "";
            if (a[i] == '(')
            {
                while (a[i] != ')')
                {
                    prviK += a[i]; i++;
                }
                prviK += ")"; i++;
            }
            else
            {
                while (!operacije.Contains(a[i]))
                {
                    prviK += a[i]; i++;
                }
            }

            operacijaK = a[i]; i++;

            if (a[i] == '(')
            {
                while (a[i] != ')')
                {
                    drugiK += a[i]; i++;
                }
                drugiK += ")";
            }
            else
            {
                while (i < a.Length)
                {
                    drugiK += a[i]; i++;
                }
            }
            return 0;
        }
        public double prviKRe()
        {
            char[] cifre = prviK.ToArray(); int i = 1; string value = "";
            while (!operacije.Contains(cifre[i]))
            {
                value += cifre[i]; i++;
            }
            return Convert.ToDouble(value);
        }
        public double drugiKRe()
        {
            char[] cifre = drugiK.ToArray(); int i = 1; string value = "";
            while (!operacije.Contains(cifre[i]))
            {
                value += cifre[i]; i++;
            }
            return Convert.ToDouble(value);
        }
        public double prviKIm()
        {
            char[] cifre = prviK.ToArray(); int i = 2; string value = "";
            while (!operacije.Contains(cifre[i])) { i++; }
            while (cifre[i] != ')') { value+= cifre[i]; i++; }
            return Convert.ToDouble(value);
        }
        public double drugiKIm()
        {
            char[] cifre = drugiK.ToArray(); int i = 2; string value = "";
            while (!operacije.Contains(cifre[i])) { i++; }
            while (cifre[i] != ')') { value += cifre[i]; i++; }
            return Convert.ToDouble(value);
        }
        public double rezKRe()
        {
            double p = prviKRe() * drugiKRe() + prviKIm() * drugiKIm();
            double r = drugiKRe() * drugiKRe() + drugiKIm() * drugiKIm();
            if (operacijaK == '+') { return prviKRe() + drugiKRe(); }
            else if (operacijaK == '-') { return prviKRe() - drugiKRe(); }
            else if (operacijaK == 'x') { return prviKRe() * drugiKRe() - prviKIm() * drugiKIm(); }
            else if (operacijaK == '/') { return p / r; }
            else return 0;
        }
        public double rezKIm()
        {
            double r = drugiKRe() * drugiKRe() + drugiKIm() * drugiKIm();
            double q = prviKIm() * drugiKRe() - prviKRe() * drugiKIm();
            if (operacijaK == '+') { return prviKRe() + drugiKRe(); }
            else if (operacijaK == '-') { return prviKRe() - drugiKRe(); }
            else if (operacijaK == 'x') { return prviKRe() * drugiKIm() - prviKIm() * drugiKRe(); }
            else if (operacijaK == '/') { return q / r; }
            else return 0;
        }
        public string rezK()
        {
            return rezKRe().ToString() + rezKIm().ToString();
        }
    }
}
