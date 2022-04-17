using Poker.Controller;
using System;
using System.Windows.Forms;

namespace Poker.View
{
    public partial class StartupForm : Form
    {
        private bool exit = true;
        readonly GameForm parent;
        public StartupForm(GameForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            if (nud_Points.Value >= nud_Bet.Value && nud_Points.Value != 0 && nud_Bet.Value != 0)
            {
                parent.Bet = (int)nud_Bet.Value;
                parent.Points = (int)nud_Points.Value;
                exit = false;
                Close();
            }
            else
            {
                MessageBox.Show("Unesite validne vrednosti! Polja \"Poeni\" i \"Ulog\" moraju biti veca od 0, a polje \"Poeni\" mora biti vece ili jednako polju \"Ulog\"",
                                "Neispravan unos!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void StartupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.SetExit(exit);
        }

        private void Nud_Points_ValueChanged(object sender, EventArgs e)
        {
            nud_Bet.Maximum = nud_Points.Value;
        }

        private void StartupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit && DialogResult.No == MessageBox.Show("Da li zelite da zatvorite aplikaciju?",
                                                           "Zatvaranje aplikacije",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question)) e.Cancel = true;
        }
    }
}
