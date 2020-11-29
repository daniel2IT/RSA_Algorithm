using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // for files/folder
using NUnit.Framework;
using System.Numerics;
using Xunit;
using System.Diagnostics;

namespace RSA_algorithm
{
    public partial class RSA_Algorithm : Form
    {
        public RSA_Algorithm()
        {
            // p minimum 11 , q minimum 13, kad butu tas chas 97 ir > 

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Patikrinimas ar Key yra paprastas
        private bool IsTheNumberSimple(BigInteger n)
        {
            if (n < 2) return false;

            if (n == 2) return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0) return false;

            return true;
        }

        // d radimas bendro dalyklio kad butu = 1 (d turi buti taip pat paprastam su m).
        private BigInteger Calculate_DBD(BigInteger m)
        {
            BigInteger d = m - 1; // kandidatai 

            for (BigInteger i = 2; i <= m; i++) // i - 1 is karto ismetam ... 
                if ((m % i == 0) && (d % i == 0)) //jeigu jie turi tokius pacius dalyklius
                {
                    d--;
                    i = 1;
                }

            return d; //19

        }

        // Privatus Raktas
        private BigInteger Calculate_d(BigInteger d, BigInteger m) // d ir Fn 
        {
            long e = 10; // yra 10 isrenkam dalyklius 1,2,5,10

            while (true)
            {
                if ((e * d) % m == 1) //Fn kaip Moda == 1
                    break;
                else e++;
            }

            return e;
        }

        // Metodas Atliekantis Desifrvima eiluciu
        private string RSA_Dedoce(List<string> input, BigInteger d, BigInteger n)
        {

            string result = "";

            BigInteger bi;
            int c = 0;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                //int index = item[i] + 97;d
                //  i++;
                //  result += characters[convertedIndex].ToString();

                //  int index = Convert.ToInt32(bi.ToString());

                //result += characters[index].ToString();

                c = (int)bi;

                result += Convert.ToChar(c);
            }
            return result;
        }

        // Metodas kuris atlieka eiluciu sifravima
        private List<string> RSA_Endoce(string s, BigInteger e, BigInteger n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            char[] charText = s.ToCharArray();
            int[] intText = new int[charText.Length];

            for (int i = 0; i < charText.Length; i++)
            {

                intText[i] = charText[i];
            }

            for (int i = 0; i < s.Length; i++)
            {

                int index = Array.IndexOf(charText, s[i]);

                bi = new BigInteger(intText[i]);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        public BigInteger musuP;
        public BigInteger musuQ;
        private (BigInteger, BigInteger) PirminiuRadimas()
        {

            long n = Convert.ToInt64(textBox_n.Text); // musu n 

            for (BigInteger prime1 = 0; prime1 < n; prime1++)
            {

                for (BigInteger prime2 = 0; prime2 < n; prime2++)
                {

                    if (prime1 * prime2 == n)
                    {
                        musuP = prime1;
                        musuQ = prime2;
                    }

                }
            }
            return (musuP, musuQ);

        }

        /*     char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                                    'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                                                    'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                    '8', '9', '0' } - NOT SECURE OPTION;*/

        public static void DeleteLastLine(string filepath)
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();

            File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 1).ToArray());

        }

        private void DecryptionBTN_Click(object sender, EventArgs e)
        {
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                //pirmo line issirinkimas
                BigInteger n = BigInteger.Parse(File.ReadLines("out1.txt").First());
                // deleting 1 line
                var SkipN = File.ReadAllLines("out1.txt").Skip(1);
                File.WriteAllLines("out1.txt", SkipN);
                //Last line issirinkimas
                BigInteger DBD = BigInteger.Parse(File.ReadLines("out1.txt").Last());
                // deleting last line
                DeleteLastLine("out1.txt");

                List<string> input = new List<string>();
                /////////////////////////P ir Q radimas/////////////////////////
                BigInteger p;
                BigInteger q;
                var resultt = PirminiuRadimas();
                q = resultt.Item1;
                p = resultt.Item2;
                /////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////
                /////////////////////////Privacio Rakto Radimas///////////////////////////////
                BigInteger Fn = (p - 1) * (q - 1);

                BigInteger privateKey = Calculate_d(DBD, Fn); // Privatus Raktas

                StreamReader sr = new StreamReader("out1.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());

                }
                //  foreach(string a in input)
                //   {
                //  MessageBox.Show("a = " + a); 
                //   }

                sr.Close();

                string result = RSA_Dedoce(input, privateKey, n);
                //MessageBox.Show("RESULT  = " + result);
                StreamWriter sw = new StreamWriter("out2.txt");
                sw.Write(result); //Line
                sw.Close();

                Process.Start("out2.txt");
            }
            else MessageBox.Show("Type Key!");
        }

        private void EnryptionBTN_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                BigInteger p = Convert.ToInt64(textBox_p.Text);
                BigInteger q = Convert.ToInt64(textBox_q.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = "";

                    StreamWriter swin = new StreamWriter("in.txt");

                    swin.WriteLine(textiFaila.Text); //Line

                    swin.Close();
                    StreamReader sr = new StreamReader("in.txt");

                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine();
                    }

                    sr.Close();

                    //    s = s.ToUpper();

                    BigInteger n = p * q;
                    BigInteger Fn = (p - 1) * (q - 1);
                    BigInteger DBD = Calculate_DBD(Fn); // Viesasis Raktas
                    BigInteger d = Calculate_d(DBD, Fn); // Privatus Raktas

                    List<string> result = RSA_Endoce(s, d, n);

                    StreamWriter sw = new StreamWriter("out1.txt");

                    // n is first line
                    sw.WriteLine(n);
                    foreach (string item in result)
                    {
                        sw.WriteLine(item);
                    }
                    //DBD bus last line faile
                    sw.WriteLine(DBD);

                    sw.Close();
                    viesasisRaktas.Text = DBD.ToString();
                    textBox_d.Text = d.ToString();
                    textBox_n.Text = n.ToString();

                    Process.Start("out1.txt");
                }
                else MessageBox.Show("p ar q - make sure that they're prime numbers!");
            }
            else MessageBox.Show("Type p and q > than 20 !");

        }

    }
}