using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_лб_крипта_С
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static String ToTrenary(int value)
        {
            if (value == 0)
                return "";

            StringBuilder Sb = new StringBuilder();
            Boolean signed = false;

            if (value < 0)
            {
                signed = true;
                value = -value;
            }

            while (value > 0)
            {
                Sb.Insert(0, value % 3);
                value /= 3;
            }

            if (signed)
                Sb.Insert(0, '-');

            return Sb.ToString();
        }
        double search_i(string text, int N, string[,] alfavit, int step)
        {
            double rez = 0;
            int ch = 0;
            for (int i = 0; i < N; i = i + step)
            {
                string k = text.Substring(i, 1);
                for (int j = 0; j < 33; j++)
                {
                    if (k == alfavit[j, 0])
                    {
                        alfavit[j, 1] = Convert.ToString(Convert.ToInt32(alfavit[j, 1]) + 1);
                        break;
                    }
                }
                ch++;
            }
            for (int j = 0; j < 33; j++)
            {
                double a = Convert.ToInt32(alfavit[j, 1]) * (Convert.ToInt32(alfavit[j, 1]) - 1);
                rez = rez + a;
            }
            rez = rez / (ch * (ch - 1));
            return rez;
        }
        void zap(string [,] alfavit)
        {
            alfavit[0, 0] = "А";
            alfavit[1, 0] = "Б";
            alfavit[2, 0] = "В";
            alfavit[3, 0] = "Г";
            alfavit[4, 0] = "Д";
            alfavit[5, 0] = "Е";
            alfavit[6, 0] = "Ё";
            alfavit[7, 0] = "Ж";
            alfavit[8, 0] = "З";
            alfavit[9, 0] = "И";
            alfavit[10, 0] = "Й";
            alfavit[11, 0] = "К";
            alfavit[12, 0] = "Л";
            alfavit[13, 0] = "М";
            alfavit[14, 0] = "Н";
            alfavit[15, 0] = "О";
            alfavit[16, 0] = "П";
            alfavit[17, 0] = "Р";
            alfavit[18, 0] = "С";
            alfavit[19, 0] = "Т";
            alfavit[20, 0] = "У";
            alfavit[21, 0] = "Ф";
            alfavit[22, 0] = "Х";
            alfavit[23, 0] = "Ц";
            alfavit[24, 0] = "Ч";
            alfavit[25, 0] = "Ш";
            alfavit[26, 0] = "Щ";
            alfavit[27, 0] = "Ъ";
            alfavit[28, 0] = "Ы";
            alfavit[29, 0] = "Ь";
            alfavit[30, 0] = "Э";
            alfavit[31, 0] = "Ю";
            alfavit[32, 0] = "Я";
            alfavit[0, 1] = "0";
            alfavit[1, 1] = "0";
            alfavit[2, 1] = "0";
            alfavit[3, 1] = "0";
            alfavit[4, 1] = "0";
            alfavit[5, 1] = "0";
            alfavit[6, 1] = "0";
            alfavit[7, 1] = "0";
            alfavit[8, 1] = "0";
            alfavit[9, 1] = "0";
            alfavit[10, 1] = "0";
            alfavit[11, 1] = "0";
            alfavit[12, 1] = "0";
            alfavit[13, 1] = "0";
            alfavit[14, 1] = "0";
            alfavit[15, 1] = "0";
            alfavit[16, 1] = "0";
            alfavit[17, 1] = "0";
            alfavit[18, 1] = "0";
            alfavit[19, 1] = "0";
            alfavit[20, 1] = "0";
            alfavit[21, 1] = "0";
            alfavit[22, 1] = "0";
            alfavit[23, 1] = "0";
            alfavit[24, 1] = "0";
            alfavit[25, 1] = "0";
            alfavit[26, 1] = "0";
            alfavit[27, 1] = "0";
            alfavit[28, 1] = "0";
            alfavit[29, 1] = "0";
            alfavit[30, 1] = "0";
            alfavit[31, 1] = "0";
            alfavit[32, 1] = "0";
        }
        void zap(string[,] alfavit,int a)
        {
            alfavit[0, 0] = "А";
            alfavit[1, 0] = "Б";
            alfavit[2, 0] = "В";
            alfavit[3, 0] = "Г";
            alfavit[4, 0] = "Д";
            alfavit[5, 0] = "Е";
            alfavit[6, 0] = "Ё";
            alfavit[7, 0] = "Ж";
            alfavit[8, 0] = "З";
            alfavit[9, 0] = "И";
            alfavit[10, 0] = "Й";
            alfavit[11, 0] = "К";
            alfavit[12, 0] = "Л";
            alfavit[13, 0] = "М";
            alfavit[14, 0] = "Н";
            alfavit[15, 0] = "О";
            alfavit[16, 0] = "П";
            alfavit[17, 0] = "Р";
            alfavit[18, 0] = "С";
            alfavit[19, 0] = "Т";
            alfavit[20, 0] = "У";
            alfavit[21, 0] = "Ф";
            alfavit[22, 0] = "Х";
            alfavit[23, 0] = "Ц";
            alfavit[24, 0] = "Ч";
            alfavit[25, 0] = "Ш";
            alfavit[26, 0] = "Щ";
            alfavit[27, 0] = "Ъ";
            alfavit[28, 0] = "Ы";
            alfavit[29, 0] = "Ь";
            alfavit[30, 0] = "Э";
            alfavit[31, 0] = "Ю";
            alfavit[32, 0] = "Я";
            alfavit[0, 1] = "0";
            alfavit[1, 1] = "0";
            alfavit[2, 1] = "0";
            alfavit[3, 1] = "0";
            alfavit[4, 1] = "0";
            alfavit[5, 1] = "0";
            alfavit[6, 1] = "0";
            alfavit[7, 1] = "0";
            alfavit[8, 1] = "0";
            alfavit[9, 1] = "0";
            alfavit[10, 1] = "0";
            alfavit[11, 1] = "0";
            alfavit[12, 1] = "0";
            alfavit[13, 1] = "0";
            alfavit[14, 1] = "0";
            alfavit[15, 1] = "0";
            alfavit[16, 1] = "0";
            alfavit[17, 1] = "0";
            alfavit[18, 1] = "0";
            alfavit[19, 1] = "0";
            alfavit[20, 1] = "0";
            alfavit[21, 1] = "0";
            alfavit[22, 1] = "0";
            alfavit[23, 1] = "0";
            alfavit[24, 1] = "0";
            alfavit[25, 1] = "0";
            alfavit[26, 1] = "0";
            alfavit[27, 1] = "0";
            alfavit[28, 1] = "0";
            alfavit[29, 1] = "0";
            alfavit[30, 1] = "0";
            alfavit[31, 1] = "0";
            alfavit[32, 1] = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            string[,] alfavit = new string[33, 2];
            zap(alfavit);
            string text = textBox1.Text;
            text = text.Replace(" ", "");
            text = text.Replace("\r", "");
            text = text.Replace("\n", "");
            text = text.ToUpper();
            double chislo = 0;
            int step = 2;
            int N = text.Length;
            List<double> mass_chislo = new List<double>();
            while (chislo < 0.0533)
            {
                chislo = 0;
                chislo = search_i(text, N, alfavit, step);
                mass_chislo.Add(chislo);
                if (chislo < 0.0533)
                {
                    step++;
                    zap(alfavit, 0);
                }
                if (step == 10)
                {
                    break;
                }
            }
            if (step == 10)
            {
                double prov = 0.0523;
                step = 2;
                while (chislo < prov)
                {
                    chislo = 0;
                    chislo = search_i(text, N, alfavit, step);
                    mass_chislo.Add(chislo);
                    if (chislo < 0.0533)
                    {
                        step++;
                        zap(alfavit, 0);
                    }
                    if (step == 10)
                    {
                        prov = prov - 0.1;
                        step = 2;
                    }
                }
            }
            List<string> sbortxt = new List<string>();
            int nach = 0;
            while (nach < step)
            {
                sbortxt.Add("");
                for (int i = nach; i < N; i = i + step)
                {
                    sbortxt[nach] += text.Substring(i, 1);
                }
                nach++;
            }
            string rez = "";
            int[] rez_mass = new int[step];
            for (int i = 0; i < step; i++)
            {
                for (int j = 0; j < sbortxt[i].Length; j++)
                {
                    string k = sbortxt[i].Substring(j, 1);
                    for (int lj = 0; lj < 33; lj++)
                    {
                        if (k == alfavit[lj, 0])
                        {
                            alfavit[lj, 1] = Convert.ToString(Convert.ToInt32(alfavit[lj, 1]) + 1);
                            break;
                        }
                    }
                }
                double max = 0;
                int indmax = 0;
                for (int j = 0; j < 33; j++)
                {
                    if (max < Convert.ToDouble(alfavit[j, 1]))
                    {
                        max = Convert.ToDouble(alfavit[j, 1]);
                        indmax = j;
                    }
                }
                int reznm = indmax - 15;
                if (reznm < 0)
                {
                    reznm += 33;
                }
                rez_mass[i] = reznm;
                rez += alfavit[reznm, 0];
                zap(alfavit, 0);
            }
            textBox3.Text = rez;
            int chiklstep = 0;
            int[] text_mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                for (int lj = 0; lj < 33; lj++)
                {
                    if (text.Substring(i, 1) == alfavit[lj, 0])
                    {
                        text_mass[i] = lj;
                        break;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                text_mass[i] = text_mass[i] - rez_mass[chiklstep];
                if (text_mass[i] < 0)
                {
                    text_mass[i] += 33;
                }
                chiklstep++;
                if (chiklstep == step)
                {
                    chiklstep = 0;
                }
            }
            string sxr = "";
            for (int i = 0; i < N; i++)
            {
                string k = "";
                k = alfavit[text_mass[i], 0];
                sxr += k;
                textBox2.Text += k;
            }
        }
    }
}
