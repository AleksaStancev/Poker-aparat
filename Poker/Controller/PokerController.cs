using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poker.Model;
using Poker.View;

namespace Poker.Controller
{
    public class PokerController
    {
        private readonly GameForm view;
        private readonly PokerModel model;
        private int lastEvaluation;

        public PokerController(PokerModel pokerModel, GameForm gameForm)
        {
            model = pokerModel;
            view = gameForm;
            view.SetController(this);
        }

        public void ShowView()
        {
            view.Show();
        }

        public void OnLoad()
        {
            model.Bet = view.Bet;
            model.Points = view.Points;
        }
        public void OnDeal(bool swapDeal)
        {
            if(!swapDeal) model.Deal();
            lastEvaluation = model.EvaluateHand(out string message);
            view.SetPossibleWinLabel(message);
            view.AnimateDeal(model.GetHand(), swapDeal);
        }
        public void OnSwap()
        {
            int[] indexes = view.SwapIndex;
            model.Swap(indexes.Length, indexes);
            view.AnimateSwap(model.GetHand());
        }
        public void OnUpdatePoints()
        {
            if (lastEvaluation != 0)
            {
                int dobitak;
                view.Points = model.Points += dobitak = lastEvaluation * model.Bet;
                view.SetWinTxt("Dobitak: " + dobitak.ToString() + " poena!");
            }
            else
            {
                view.SetWinTxt("");
                if (model.Points < model.Bet) view.NoPointsLeft();
            }
        }
        public void OnBetPlaced()
        {
            view.Points = model.Points -= model.Bet;
        }
    }
}
