﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public partial class Form1 : Form
    {
        public string setup = "......................#..........#.......#.#..........................#.............................";
        public int laenge = 10;
        public int breite = 10;
        public Zelle[,] Spielfeld;
        public Zelle[,] Spielfeld2;
        public Form1()
        {
            InitializeComponent();
<<<<<<< .mine
            spielfelderzeugen();
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
        }
=======
            this.ClientSize = new System.Drawing.Size(51*laenge, 51*breite);
>>>>>>> .r157

        private void spielfelderzeugen()
        {
            this.ClientSize = new System.Drawing.Size(50 * laenge, 50 * breite);


            this.Spielfeld = new Zelle[laenge, breite]; // es wird nur ein array erzeugt

            for (int y = 0; y < laenge; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    if (setup[y * laenge + x] == '.')
                    {
                        Spielfeld[x, y] = new Zelle(false);

                    }
                    else
                    {
                        Spielfeld[x, y] = new Zelle(true);
                    }
                    Spielfeld[x, y].Location = new Point(x * 51, y * 51);
                    Spielfeld[x, y].Size = new Size(50, 50);
                    Spielfeld[x, y].Name = ("Feld" + x.ToString() + y.ToString());
                    this.Controls.Add(this.Spielfeld[x, y]);

                }
            }
        }

        private void Regeln()
        {
            this.Spielfeld2 = new Zelle[laenge, breite];
            int lebendenachbarn = 0;


            for (int x = 0; x < laenge; x++)
            {
                for (int y = 0; y < breite; y++)
                {


                    if (Spielfeld[ykord(y - 1), xkord(x - 1)].zustand == true) { lebendenachbarn++; } //nordwest
                    if (Spielfeld[ykord(y - 1), xkord(x)].zustand == true) { lebendenachbarn++; } //nord
                    if (Spielfeld[ykord(y - 1), xkord(x + 1)].zustand == true) { lebendenachbarn++; } //nordost
                    if (Spielfeld[ykord(y), xkord(x - 1)].zustand == true) { lebendenachbarn++; } //west
                    if (Spielfeld[ykord(y), xkord(x + 1)].zustand == true) { lebendenachbarn++; }// südost
                    if (Spielfeld[ykord(y + 1), xkord(x - 1)].zustand == true) { lebendenachbarn++; }//südwest
                    if (Spielfeld[ykord(y + 1), xkord(x)].zustand == true) { lebendenachbarn++; }//süden
                    if (Spielfeld[ykord(y + 1), xkord(x + 1)].zustand == true) { lebendenachbarn++; } //südost
                }
            }
        }
        public int ykord(int y)
        {
            int n = 0;
            if (y < 0)
            {
                n = laenge - 1;
            }
            else if (y == laenge)
            {
                n = 0;
            }
            //else if (y == 0){ y = laenge -1;}
            else { n = y; }
            return n;
        }
        public int xkord(int x)
        {
            int k = 0;
            if (x < 0)
            {

                k = breite - 1;
            }
            else if (x == breite)
            {
                k = 0;
            }
            else { k = x; }
            return k;

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < laenge; x++)
            {
                for (int y = 0; y < breite; y++)
                {
                    Spielfeld[x, y].Size = new Size(this.ClientRectangle.Width / breite, this.ClientRectangle.Height / laenge);
                    Spielfeld[x, y].Location = new Point((x * (this.ClientRectangle.Width / breite)), (y * (this.ClientRectangle.Height / laenge)));
                    GOTT.Location = new Point((x * (this.ClientRectangle.Width / breite))+100, (y * (this.ClientRectangle.Height / laenge))+100);
                }
            }
        }

        private void GOTT_Click(object sender, EventArgs e)
        {
            Regeln();
        }
    }


    public class Zelle : System.Windows.Forms.Panel
    {
        public Zelle(bool Seinodernichtsein = false)
        {
            setZustand(Seinodernichtsein);

        }

        public bool zustand = false;

        public void setZustand(bool farbänderung)
        {
            this.zustand = farbänderung;
            if (!this.zustand) this.BackColor = System.Drawing.Color.Red;
            else this.BackColor = System.Drawing.Color.Blue;

        }
    }
}
