using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator___Jovan_Dragas
{
    class Long
    {
        public string mantisa;
        public int eksponent, znak;

        public static Long kec, nula;
        public static int acc;
        static Long()
        {
            kec = new Long("1");
            nula = new Long("0");
            acc = 30;
        }
        public string broj
        {
            get
            {
                string z = "";
                if (znak == -1) z = "-";
                if (mantisa == "0") return mantisa;
                if (eksponent == 0) return z + mantisa;
                while (mantisa.Length - eksponent <= 0)
                    mantisa = "0" + mantisa;
                return z + mantisa.Insert(mantisa.Length - eksponent, ".");
            }
        }
        public Long(string mantisa, int eksponent, int znak)
        {
            this.mantisa = mantisa;
            if (this.mantisa.Intersect("123456789").Count() == 0) this.mantisa = "0";
            this.eksponent = eksponent;
            this.znak = znak;
        }
        public Long(string broj)
        {
            znak = 1;
            this.mantisa = "ibarska magistrala";
            if (broj.Length == 0) return;

            if (broj[0] == '-')
            {
                broj = broj.Substring(1);
                znak = -1;
            }
            for (int i = 0; i < broj.Length; i++)
            {
                if ((broj[i] < 48 || broj[i] > 57) && broj[i] != '.') return;
            }

            if (broj.Count(c => c == '.') > 1) return;
            if (broj.Count(c => c == '.') == 0)
            {
                this.eksponent = 0;
                this.mantisa = broj;
                return;
            }
            broj = broj.Trim('0');
            if (broj == "")
            {
                this.eksponent = 0;
                this.mantisa = "0";
            }
            this.eksponent = broj.Length - broj.IndexOf('.') - 1;
            this.mantisa = broj.Substring(0, broj.IndexOf('.')) + broj.Substring(broj.IndexOf('.') + 1, broj.Length - broj.IndexOf('.') - 1);
        }
        public static Long operator +(Long A, Long B)
        {
            if (A.mantisa == "ibarska magistrala" || B.mantisa == "ibarska magistrala") return new Long("ibarska magistrala");
            int znak = 1;
            if (A.znak == -1 && B.znak == 1) return B - new Long(A.mantisa, A.eksponent, 1);
            if (A.znak == 1 && B.znak == -1) return A - new Long(B.mantisa, B.eksponent, 1);
            if (A.znak == -1 & B.znak == -1) znak = -1;
            int maxEx = Math.Max(A.eksponent, B.eksponent);
            string mantisa = "";
            A.mantisa = A.mantisa.Replace(".", "");
            B.mantisa = B.mantisa.Replace(".", "");

            for (int i = A.eksponent; i < maxEx; i++) A.mantisa += "0";
            for (int i = B.eksponent; i < maxEx; i++) B.mantisa += "0";
            int pom = 0;
            string maxMan = B.mantisa, minMan = A.mantisa;
            if (A.mantisa.Length > B.mantisa.Length)
            {
                maxMan = A.mantisa;
                minMan = B.mantisa;
            }
            for (int i = maxMan.Length - 1; i >= 0; i--)
            {
                int cifra;
                if (i >= maxMan.Length - minMan.Length)
                {
                    cifra = (maxMan[i] - 48 + minMan[i - maxMan.Length + minMan.Length] - 48 + pom);
                }
                else
                {
                    cifra = (maxMan[i] - 48 + pom);
                }
                pom = cifra / 10;
                mantisa = (cifra % 10).ToString() + mantisa;
            }
            if (pom == 1) mantisa = "1" + mantisa;
            return new Long(mantisa, maxEx, znak);
        }
        public static Long operator -(Long A, Long B)
        {
            if (A.mantisa == "ibarska magistrala" || B.mantisa == "ibarska magistrala") return new Long("ibarska magistrala");
            int maxEx = Math.Max(A.eksponent, B.eksponent), znak = 1;
            string mantisa = "";
            if (A.znak == -1 && B.znak == 1) return A + new Long(B.mantisa, B.eksponent, -1);
            if (A.znak == 1 && B.znak == -1) return A + new Long(B.mantisa, B.eksponent, 1);
            if (A.znak == -1 & B.znak == -1) znak = -1;
            A.mantisa = A.mantisa.Replace(".", "");
            B.mantisa = B.mantisa.Replace(".", "");
            for (int i = A.eksponent; i < maxEx; i++) A.mantisa += "0";
            for (int i = B.eksponent; i < maxEx; i++) B.mantisa += "0";
            int pom = 0;
            string maxMan = B.mantisa, minMan = A.mantisa;
            if (A.mantisa.Length > B.mantisa.Length)
            {
                maxMan = A.mantisa;
                minMan = B.mantisa;
            }
            int a = A.mantisa.Length, b = B.mantisa.Length;
            for (int i = a; i < b; i++) A.mantisa = "0" + A.mantisa;
            for (int i = b; i < a; i++) B.mantisa = "0" + B.mantisa;
            for (int i = maxMan.Length - 1; i >= 0; i--)
            {
                int cifra;
                cifra = A.mantisa[i] - B.mantisa[i] - pom;
                if (cifra < 0)
                {
                    pom = 1;
                    cifra = 10 + cifra;
                }
                else pom = 0;

                mantisa = cifra + mantisa;
            }
            if (pom == 1)
            {
                znak = -1;
                string mantisa2 = "1";
                for (int i = 0; i < maxMan.Length; i++)
                {
                    mantisa2 += "0";
                }
                A = new Long(mantisa);
                mantisa = (new Long(mantisa2) - A).mantisa;
            }
            mantisa = mantisa.TrimStart('0');
            return new Long(mantisa, maxEx, znak);
        }
        public static Long operator *(Long A, Long B)
        {
            if (A.mantisa == "ibarska magistrala" || B.mantisa == "ibarska magistrala") return new Long("ibarska magistrala");
            int znak = 1, exp = 0;
            Long res = new Long("0"),
                jedan = new Long("1");
            if (A.znak * B.znak == -1) znak *= -1;
            exp = A.eksponent + B.eksponent;
            A.mantisa.Replace(".", "");
            B.mantisa.Replace(".", "");
            A = new Long(A.mantisa);
            B = new Long(B.mantisa);
            for (int i = 0; i < B.mantisa.Length; i++)
            {
                int temp = B.mantisa[B.mantisa.Length - i - 1] - 48;
                Long C = new Long("0");
                for (int j = 0; j < temp; j++)
                {
                    C = C + A;
                }
                for (int j = 0; j < i; j++)
                {
                    C.mantisa += "0";
                }
                res = res + C;
            }
            res.eksponent = exp;
            res.znak = znak;
            return res;
        }
        public static Long operator /(Long A, Long B)
        {
            if (A.mantisa == "ibarska magistrala" || B.mantisa == "ibarska magistrala") return new Long("ibarska magistrala");
            if (B.mantisa == "0") return new Long("e");
            int znak = 1, exp = 0;
            Long br = new Long("0");
            exp = A.eksponent - B.eksponent;
            A = new Long(A.mantisa);
            B = new Long(B.mantisa);
            string res = "";
            Long temp2 = new Long("0");
            foreach (char c in A.mantisa)
            {
                Long temp = new Long(temp2.mantisa + c);
                int i = 0;
                while (temp - B != new Long("0") && (temp - B).znak != -1)
                {
                    temp = temp - B;
                    i++;
                }
                temp2 = temp;
                res += i;
            }
            Console.WriteLine(temp2.mantisa);
            if (temp2.mantisa.Trim('0') == "")
                return new Long(res.TrimStart('0'), br.eksponent, znak);
            for (int j = 0; j < acc; j++)
            {
                Long temp = new Long(temp2.mantisa + "0");
                int i = 0;
                while (temp - B != new Long("0") && (temp - B).znak != -1)
                {
                    temp = temp - B;
                    i++;
                }
                res += i;
                temp2 = temp;
                exp++;
                if (temp2.mantisa.Trim('0') == "") break;
            }
            return new Long(res.TrimStart('0'), exp, znak);
        }

        public static Long operator ++(Long A) { return A + kec; }
    }
}