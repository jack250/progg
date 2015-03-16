using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
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

        public void WoBinIch(object sender )
        {
            Button mme = (Button) sender;
            Point wo = mme.Location;
            int spalte = wo.X/100 +1;
            int zeile = wo.Y/100 +1;
            MessageBox.Show("ich bin in der zeile:" + zeile + "und der spalte: " + spalte);
        }

        public void tausch(Button ist, Button mme)
        {
            Button arbeitsfeld = (Button) ist;
            Button freifeld = (Button) mme;

            Point ffloc = freifeld.Location;
           // int ffx = ffloc.X;
            //int ffy = ffloc.Y;

            Point afloc = arbeitsfeld.Location;
            //int afx = afloc.X;
            //int afy = afloc.Y;

            if (afloc.X + 100 == ffloc.X && afloc.Y == ffloc.Y )
            {
                int zwischenx = afloc.X;
                int zwischeny = afloc.Y;

                afloc.X = ffloc.X;
                afloc.Y = ffloc.Y;

                ffloc.X = zwischenx;
                ffloc.Y = zwischeny;
            }
        }

        

        private void Läufer_MouseDown(object sender, MouseEventArgs e)
        {
            /*Button mme = (Button)sender;

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
            }*/
            
          
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
           // WoBinIch(sender, e);
             Button mme = (Button) freifeld;
             Button mma = (Button)sender;
            tausch (mma, mme );


        }

      
    }
}
