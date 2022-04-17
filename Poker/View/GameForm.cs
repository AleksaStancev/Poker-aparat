using Poker.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Poker.View
{
    public partial class GameForm : Form
    {
        private delegate void Animation();
        private Animation animationDelegate;
        private PokerController controller;
        private readonly List<PictureBox> pictureBoxes;
        private readonly List<PictureBox> swapBoxes;
        private bool canSwap = false;
        private bool exit = false;
        private bool isSwaping;
        private readonly List<int> swapIndexes;
        public int Bet { get => Convert.ToInt32(lbl_Bet.Text); set => lbl_Bet.Text= value.ToString(); }
        public int Points { get => Convert.ToInt32(lbl_Points.Text); set => lbl_Points.Text=value.ToString(); }
        public int[] SwapIndex => swapIndexes.ToArray();
        public void SetPossibleWinLabel(string text)
        {
            lbl_PossibleWin.Text = text;
        }
        public void SetExit(bool value)
        {
            exit = value;
        }
        public void SetWinTxt(string value)
        {
            lbl_WinPoints.Text = value;
        }
        public GameForm()
        {
            InitializeComponent();
            lbl_Win.Text = "";
            lbl_WinPoints.Text = "";
            pictureBoxes = new List<PictureBox>
            {
                pb_Card1,
                pb_Card2,
                pb_Card3,
                pb_Card4,
                pb_Card5
            };
            swapBoxes = new List<PictureBox>();
            swapIndexes = new List<int>();
            lbl_Instructions.Text = "Kliknite na dugme \"Deli\" da dobijete karte!";
        }
        public void SetController(PokerController value)
        {
            controller = value;
        }
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!exit && DialogResult.No == MessageBox.Show("Da li zelite da zatvorite aplikaciju?",
                                                           "Zatvaranje aplikacije",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question)) e.Cancel = true;
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            StartupForm temp = new StartupForm(this);
            temp.ShowDialog();
            if (exit) Close();
            else controller.OnLoad();
        }
        private void Btn_Deli_Click(object sender, EventArgs e)
        {
            if (btn_Deli.Text == "Deli")
            {
                btn_Deli.Enabled = false;
                controller.OnBetPlaced();
                swapIndexes.Clear();
                controller.OnDeal(false);
            }
            else
            {
                btn_Zameni.Enabled = false;
                foreach (var pictureBox in pictureBoxes)
                {
                    pictureBox.BorderStyle = BorderStyle.None;
                }
                lbl_Instructions.Text = "Ruka zavrsena! Za pocetak nove kliknite na dugme \"Deli\"!";
                controller.OnUpdatePoints();
                btn_Deli.Text = "Deli";
                lbl_Win.Text = lbl_PossibleWin.Text;
                canSwap = false;
            }
        }
        private void Tm_AnimateTimer_Tick(object sender, EventArgs e)
        {
            animationDelegate?.Invoke();
        }
        private void Pb_Card_Click(object sender, EventArgs e)
        {
            if (canSwap)
            {
                PictureBox pb = sender as PictureBox;
                int tag = Convert.ToInt32(pb.Tag);
                if (swapIndexes.Count < 3 && !swapIndexes.Contains(tag))
                {
                    swapIndexes.Add(tag);
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    if (btn_Zameni.Enabled == false) btn_Zameni.Enabled = true;
                }
                else if (swapIndexes.Contains(tag))
                {
                    swapIndexes.Remove(tag);
                    pb.BorderStyle = BorderStyle.None;
                    if (swapIndexes.Count == 0) btn_Zameni.Enabled = false;
                }
            }
        }
        private void Btn_Zameni_Click(object sender, EventArgs e)
        {
            btn_Zameni.Enabled = false;
            lbl_PossibleWin.Visible = false;
            swapBoxes.Clear();
            foreach (var index in swapIndexes)
            {
                foreach (var pictureBox in pictureBoxes)
                {
                    if (Convert.ToInt32(pictureBox.Tag) == index)
                    {
                        swapBoxes.Add(pictureBox);
                        break;
                    }
                }
            }
            lbl_Instructions.Text = "Zamena karata u toku!";
            animationDelegate = TimerRemoveSwapCards;
            tm_AnimateTimer.Start();
            canSwap = false;
        }
        public void AnimateDeal(string[] hand, bool swapDeal)
        {

            Point point=new Point(-300,125);
            isSwaping = swapDeal;
            if (swapDeal)
            {
                lbl_Instructions.Text = "Sortiranje u toku!";
                point.X = 0;
            }
            else
            {
                lbl_PossibleWin.Visible = false;
                lbl_Instructions.Text = "Deljenje u toku!";               
            }            
            canSwap = false;
            int i = 0;
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Location = point;
                pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(hand[i++]);
                pictureBox.BorderStyle = BorderStyle.None;
            }
            animationDelegate = TimerDealAnimation;
            tm_AnimateTimer.Start();
        }
        public void AnimateSwap(string[] hand)
        {
            int i = 0;
            foreach (var swapBox in swapBoxes)
            {
                swapBox.BorderStyle = BorderStyle.None;
                swapBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(hand[swapIndexes[i++]]);
            }
            animationDelegate = TimerReturnSwapCards;
            tm_AnimateTimer.Start();
        }
        private void TimerDealAnimation()
        {
            if (pb_Card5.Location.X <= 350) pb_Card5.Location = new Point(pb_Card5.Location.X + 25, 125);
            else if (pb_Card4.Location.X <= 275) pb_Card4.Location = new Point(pb_Card4.Location.X + 25, 125);
            else if (pb_Card3.Location.X <= 200) pb_Card3.Location = new Point(pb_Card3.Location.X + 25, 125);
            else if (pb_Card2.Location.X <= 125) pb_Card2.Location = new Point(pb_Card2.Location.X + 25, 125);
            else if (pb_Card1.Location.X <= 50) pb_Card1.Location = new Point(pb_Card1.Location.X + 25, 125);
            else
            {
                tm_AnimateTimer.Stop();
                if (!isSwaping)
                {
                    canSwap = true;
                    lbl_Instructions.Text = "Selektujte do 3 karte za zamenu! Kada ste spremni kliknite na dugme \"Zameni\"! Ako ste zadovoljni dobitkom kliknite na dugme \"Uzmi dobitak\"!";
                    btn_Deli.Text = "Uzmi dobitak";
                }
                else
                { 
                    lbl_Instructions.Text = "Ruka zavrsena! Za pocetak nove kliknite na dugme \"Deli\"!";
                    lbl_Win.Text = lbl_PossibleWin.Text;
                    controller.OnUpdatePoints();
                    btn_Deli.Text = "Deli";
                }
                btn_Deli.Enabled = true;
                btn_Deli.Focus();
                lbl_PossibleWin.Visible = true;
            }
        }
        private void TimerRemoveSwapCards()
        {
            foreach (var swapBox in swapBoxes)
            {
                swapBox.Location = new Point(swapBox.Location.X, swapBox.Location.Y - 25);
            }
            if (swapBoxes.Last().Location.Y == -125)
            {
                tm_AnimateTimer.Stop();
                controller.OnSwap();
            }
        }
        private void TimerReturnSwapCards()
        {
            foreach (var swapBox in swapBoxes)
            {
                swapBox.Location = new Point(swapBox.Location.X, swapBox.Location.Y + 25);            
            }
            if (swapBoxes.Last().Location.Y == 125)
            {
                tm_AnimateTimer.Interval = 15;
                animationDelegate = TimerCardsCollect;
            }
        }
        private void TimerCardsCollect()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                if(pictureBox.Location.X > 0) pictureBox.Location = new Point(pictureBox.Location.X - 25, pictureBox.Location.Y);
            }
            if (pictureBoxes.Last().Location.X == 0)
            {
                tm_AnimateTimer.Interval = 10;
                tm_AnimateTimer.Stop();
                controller.OnDeal(true);
            }
        }
        private void Btn_Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void NoPointsLeft()
        {
            MessageBox.Show("Ostali ste bez poena! Unesite nove poene i ulog u prozoru koji ce se otvoriti ili njegovim zatvaranjem izadjite iz aplikacije!",
                               "Nema vise poena!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            StartupForm temp = new StartupForm(this);
            temp.ShowDialog();
            if (exit) Close();
            else controller.OnLoad();
        }
    }
}
