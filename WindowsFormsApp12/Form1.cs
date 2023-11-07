using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int BinToDec(string vstup)
        {
            double desitkove = 0;
            int mocnina = 0;
            for (int i = vstup.Length - 1; i >= 0; i--)
            {
                desitkove += ((double)vstup[i] - 48) * Math.Pow(2, mocnina);
                mocnina++;

            }
            return (int)desitkove;
        }

        public string DecToBin(int vstup)
        {
            string binarni = "";
            while (vstup > 0)
            {
                binarni = (vstup % 2) + binarni;
                vstup /= 2;
            }
            return binarni;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            bool jetovpytli = false;
            foreach (char znak in vstup)
            {
                if (znak != '1' && znak != '0')
                {
                    jetovpytli = true;
                }
            }
            if (jetovpytli)
            {
                MessageBox.Show("Chyba");
            }
            else
            {
                MessageBox.Show(BinToDec(vstup).ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int vstup = int.Parse(textBox1.Text);
                MessageBox.Show(DecToBin(int.Parse(textBox1.Text)).ToString());
            }
            catch
            {
                MessageBox.Show("Chyba");
            }

        }
    }
}