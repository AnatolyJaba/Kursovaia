using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Numerics;

namespace BolotiiShifr
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (viborList.Text == "Шифр Цезаря")
            {
                Caesar ded = new Caesar(ishodniiText.Text, Convert.ToInt32(stepSh.Value));
                ded.shifre();
                konechniiText.Text = ded.otvetC();
            }
            if (viborList.Text == "Код Морзе")
            {
                Morze jij = new Morze(ishodniiText.Text, langBox.Text);
                if (shifrashBox.Text == "Шифрование")
                    jij.zash();
                if (shifrashBox.Text == "Расшифрование")
                    jij.razsh();
                konechniiText.Text = jij.otvetM();
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (viborList.Text == "Шифр Цезаря")
            {
                backButton.Visible = true;
                ishodniiText.Visible = true;
                konechniiText.Visible = true;
                startButton.Visible = true;
                stepSh.Visible = true;
                label1.Visible = false;
                viborList.Visible = false;
                chooseButton.Visible = false;
                caesarText.Visible = true;
            }
            if (viborList.Text == "Код Морзе")
            {
                backButton.Visible = true;
                ishodniiText.Visible = true;
                konechniiText.Visible = true;
                startButton.Visible = true;
                stepSh.Visible = false;
                label1.Visible = false;
                viborList.Visible = false;
                chooseButton.Visible = false;
                langBox.Visible = true;
                shifrashBox.Visible = true;
                morzeText.Visible = true;
            }
            if (viborList.Text == "RSA")
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                pBox.Visible = true;
                qBox.Visible = true;
                dBox.Visible = true;
                nBox.Visible = true;
                label1.Visible = false;
                viborList.Visible = false;
                chooseButton.Visible = false;
                buttonEncrypt.Visible = true;
                buttonDecipher.Visible = true;
                backButton.Visible = true;
                rsaText.Visible = true;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            ishodniiText.Visible = false;
            konechniiText.Visible = false;
            startButton.Visible = false;
            stepSh.Visible = false;
            label1.Visible = true;
            viborList.Visible = true;
            chooseButton.Visible = true;
            langBox.Visible = false;
            ishodniiText.Text = "";
            konechniiText.Text = "";
            stepSh.Value = 0;
            shifrashBox.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pBox.Visible = false;
            qBox.Visible = false;
            dBox.Visible = false;
            nBox.Visible = false;
            buttonDecipher.Visible = false;
            buttonEncrypt.Visible = false;
            rsaText.Visible = false;
            morzeText.Visible = false;
            caesarText.Visible = false;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA(pBox.Text, qBox.Text, dBox.Text, nBox.Text);
            rsa.Encrypt();
            long p = Convert.ToInt32(pBox.Text);
            long q = Convert.ToInt32(qBox.Text);
            nClosed.Text = Convert.ToString(p * q);
            long m = (p - 1) * (q - 1);
            long d = m - 1;
            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }
            dClosed.Text = Convert.ToString(d);
            dBox.Text = dClosed.Text;
            nBox.Text = nClosed.Text;
        }

        private void pBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void qBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA(pBox.Text, qBox.Text, dBox.Text, nBox.Text);
            rsa.Decipher();
        }
    }
    public class Caesar
    {
        public Caesar(string chach, int shift)
        {
            this.text = chach;
            this.shiftValue = shift;
        }
        public string text;

        private string result;

        public string otvetC()
        {
            return this.result;
        }
        public int shiftValue;
        public void shifre()
        {
            char[] ses = new char[(this.text.Length)];
            for (int i = 0; i < this.text.Length; i++)
            {
                if ((this.text[i] >= 'а' && this.text[i] <= 'я') || (this.text[i] >= 'А' && this.text[i] <= 'Я'))
                {
                    if (this.text[i] >= 'а' && this.text[i] <= 'я')
                    {
                        if ((this.text[i] + shiftValue > 'я'))
                            ses[i] = Convert.ToChar(this.text[i] - 32 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                        if ((this.text[i] + shiftValue < 'а'))
                            ses[i] = Convert.ToChar(this.text[i] + 32 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                    }
                    if (this.text[i] >= 'А' && this.text[i] <= 'Я')
                    {
                        if ((this.text[i] + shiftValue > 'Я'))
                            ses[i] = Convert.ToChar(this.text[i] - 32 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                        if ((this.text[i] + shiftValue < 'А'))
                            ses[i] = Convert.ToChar(this.text[i] + 32 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                    }

                }
                else if ((this.text[i] >= 'a' && this.text[i] <= 'z') || (this.text[i] >= 'A' && this.text[i] <= 'Z'))
                {
                    if (this.text[i] >= 'a' && this.text[i] <= 'z')
                    {
                        if ((this.text[i] + shiftValue > 'z'))
                            ses[i] = Convert.ToChar(this.text[i] - 25 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                        if ((this.text[i] + shiftValue < 'a'))
                            ses[i] = Convert.ToChar(this.text[i] + 25 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                    }
                    if (this.text[i] >= 'A' && this.text[i] <= 'Z')
                    {
                        if ((this.text[i] + shiftValue > 'Z'))
                            ses[i] = Convert.ToChar(this.text[i] - 25 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                        if ((this.text[i] + shiftValue < 'A'))
                            ses[i] = Convert.ToChar(this.text[i] + 25 + shiftValue);
                        else
                            ses[i] = Convert.ToChar(this.text[i] + shiftValue);
                    }
                }
            }
            this.result = new string(ses);
        }
    }
    
    public class Morze
    {
        public string text;

        public string lang;

        public string otvet;
        public Morze(string afg, string gfa)
        {
            this.text = afg;
            this.lang = gfa;
        }

        public string otvetM()
        {
            return this.otvet;
        }
        public char[] rus = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
            'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы',
            'ь', 'э','ю', 'я', '.', ',', ';', ':', '?', '!', '-', '"'};
        public char[] arus = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К',
            'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы',
            'Ь', 'Э', 'Ю', 'Я'};

        public char[] eng = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '.', ',', ';', ':', '?', '!', '-', '"'};
        public char[] aeng = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public string[] morrus = {"*-", "-***", "*--", "--*", "-**", "*", "*", "***-", "--**",
                                "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "*-*",
                                 "***", "-", "**-", "**-*", "****", "-*-*", "---*", "----", "--*-",
                                  "--*--", "-*--", "-**-", "**-**", "**--", "*-*-", "******", "*-*-*-",
                                   "-*-*-*", "---***", "**--**", "--**--", "-****-", "*-**-*"};

        public string[] moreng = {"*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****", "**",
                                "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*",
                                 "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**",
                                 "*-*-*-", "--**--", "-*-*-*", "---***", "**--**", "-*-*--", "-****-", "*-**-*"};
        public void zash()
        {
            for (int i = 0; i < this.text.Length; i++)
            {
                if (this.lang == "Английский")
                {
                    for (int j = 0; j < eng.Length; j++)
                    {
                        if (this.text[i] == eng[j] || this.text[i] == aeng[j])
                            otvet += (moreng[j] + " ");
                    }
                }
                if (this.lang == "Русский")
                {
                    for (int j = 0; j < rus.Length; j++)
                    {
                        if (this.text[i] == rus[j] || this.text[i] == arus[j])
                            otvet += (morrus[j] + " ");
                    }
                }
                if (this.text[i] == ' ')
                    otvet += "  ";
            }

        }
        public void razsh()
        {
            string[] g = text.Split();
            for (int i = 0; i < this.text.Length; i++)
            {
                if (this.lang == "Английский")
                {
                    for (int j = 0; j < moreng.Length; j++)
                    {
                        if (g[i] == moreng[j])
                            otvet += (eng[j] + " ");
                    }
                }
                if (this.lang == "Русский")
                {
                    for (int j = 0; j < morrus.Length; j++)
                    {
                        if (g[i] == morrus[j])
                            otvet += (rus[j] + " ");
                    }
                }
            }
        }
    }
    public class RSA
    {
        public string pB;
        public string qB;
        public string dB;
        public string nB;
        public RSA(string a, string b, string c, string d)
        {
            this.pB = a;
            this.qB = b;
            this.dB = c;
            this.nB = d;
        }

        public bool IsTheNumberSimple(long chisl)
        {
            if (chisl < 2)
                return false;

            if (chisl == 2)
                return true;

            for (long i = 2; i < chisl; i++)
                if (chisl % i == 0)
                    return false;

            return true;
        }

        public long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        public long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        public List<string> Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        public string Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        public char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0',
                                                'A', 'B', 'C', 'D', 'E', 'G', 'H', 'I',
                                                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                                                'U', 'V', 'W', 'X', 'Y', 'Z', '!', '?', ',', '.'};
        public void Encrypt()
        {
            if ((pB.Length > 0) && (qB.Length > 0))
            {
                long p = Convert.ToInt64(pB);
                long q = Convert.ToInt64(qB);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = "";

                    StreamReader sr = new StreamReader("in.txt");

                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine();
                    }

                    sr.Close();

                    s = s.ToUpper();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = Endoce(s, e_, n);

                    StreamWriter sw = new StreamWriter("out1.txt");
                    foreach (string item in result)
                        sw.WriteLine(item);
                    sw.Close();
                    
                    dB = d.ToString();
                    nB = n.ToString();

                    Process.Start("out1.txt");
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }
        public void Decipher()
        {
            if ((dB.Length > 0) && (nB.Length > 0))
            {
                long d = Convert.ToInt64(dB);
                long n = Convert.ToInt64(nB);

                List<string> input = new List<string>();

                StreamReader sr = new StreamReader("out1.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                string result = Dedoce(input, d, n);

                StreamWriter sw = new StreamWriter("out2.txt");
                sw.WriteLine(result);
                sw.Close();
                    
                Process.Start("out2.txt");
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
