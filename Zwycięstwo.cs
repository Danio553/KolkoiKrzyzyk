using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KolkoiKrzyzyk
{
    public partial class Zwycięstwo : Form
    {
        public string Wygrany;
        private Form1 Plansza;
        public Zwycięstwo(Form1 P)
        {
            Plansza = P;
            InitializeComponent();
        }

        private void pokazZwyciezce(object sender, EventArgs e)
        {
         
            wlabel2.Text = "Wygrywa : " + Wygrany;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Plansza.wyczyść();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

