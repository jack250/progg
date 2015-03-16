using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonverschieben150121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Läufer_MouseDown(object sender, MouseEventArgs e)
        {
            Button mme = (Button)sender;

            double xmp = mme.Width*0.5;
            double ymp = mme.Height*0.5;

            double mmx;
            mmx = e.X;

            double mmy;
            mmy = e.Y;

            double xrel = (mmx - xmp)/(0.5*mme.Width);
            double yrel = (mmy - ymp)/(0.5*mme.Height);

            if (xrel <- yrel && xrel > yrel) // oben
            {
                mme.Top = mme.Top - mme.Height;
            }
            else if (xrel >- yrel && xrel > yrel)//rechts
            {
                mme.Left = mme.Left + mme.Width;
            }  
            else if (xrel > -yrel && xrel< yrel)//unten
            {
                mme.Top = mme.Top + mme.Height;
            }
            else if (xrel < -yrel && xrel < yrel) // links
            {
                mme.Left = mme.Left - mme.Width;
            }
        }
    }
}
