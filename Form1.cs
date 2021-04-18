using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoiKrzyzyk
{
    enum CurrentPlayer
    {
        Kolko,
        Krzyzyk
    }
    public partial class Form1 : Form
    {
        CurrentPlayer cp;
        public Form1()
        {
            InitializeComponent();
            cp = CurrentPlayer.Krzyzyk;
            changelabel();
            A1.Enabled = true;
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (cp == CurrentPlayer.Krzyzyk)
            {
                senderButton.Text = "X";
                cp = CurrentPlayer.Kolko;
            }
            else
            {
                senderButton.Text = "O";
                cp = CurrentPlayer.Krzyzyk;
            }
            SystemWygranej();
            changelabel();
        }
        public void changelabel()
        {
            if (cp == CurrentPlayer.Krzyzyk)
            {
                Currentlabel2.Text = "Krzyżyk";
            }
            else
            {
                Currentlabel2.Text = "Kółko";
            }
        }

        public void SystemWygranej()
        {
            if (A1.Text != "" && A1.Text == A2.Text && A2.Text == A3.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A1.Text;
                wygrana.Show();
            }
            else if (B1.Text != "" && B1.Text == B2.Text && B2.Text == B3.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = B1.Text;
                wygrana.Show();
            }
            else if (C1.Text != "" && C1.Text == C2.Text && C2.Text == C3.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = C1.Text;
                wygrana.Show();
            }
            else if (A1.Text != "" && A1.Text == B1.Text && B1.Text == C1.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A1.Text;
                wygrana.Show();
            }
            else if (A2.Text != "" && A2.Text == B2.Text && B2.Text == C2.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A2.Text;
                wygrana.Show();
            }
            else if (A3.Text != "" && A3.Text == B3.Text && B3.Text == C3.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A3.Text;
                wygrana.Show();
            }
            else if (A1.Text != "" && A1.Text == B2.Text && B2.Text == C3.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A1.Text;
                wygrana.Show();
            }
            else if (A3.Text != "" && A3.Text == B2.Text && B2.Text == C1.Text)
            {
                Zwycięstwo wygrana = new Zwycięstwo(this);
                wygrana.Wygrany = A3.Text;
                wygrana.Show();
            }

        }
        public void wyczyść()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
        }


    }
}




         
            
        


        