using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quersumme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint wert = (uint)zahl.Value;

            if (QS.Checked)
            {
                labErgebniss.Text = Quersumme(wert).ToString();
            }
            else if (einfacheQS.Checked)
            {
                labErgebniss.Text = einfacheQuersumme(wert).ToString();
            }
        }


        public uint LängeZahl(uint wert)
        {
            uint Länge = (uint)(1 + Math.Log10(wert)) ;
            return Länge;
        }


        public uint Quersumme( uint Länge)
        {
            uint ergebniss = 0;

            while (Länge > 0)
            {
                ergebniss += Länge % 10;
                Länge = Länge /10;
            }
            return ergebniss;
        }

        public uint einfacheQuersumme(uint Länge)
        {
            uint ergebniss2 = 0;
            do
            {
                ergebniss2 += Länge % 10;
                Länge = Länge / 10;
                ergebniss2 = Länge;

            }
            while (ergebniss2 > 10);
            return ergebniss2;
        }
    }

}
