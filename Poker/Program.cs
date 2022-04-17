using Poker.Model;
using System;
using System.Windows.Forms;
using Poker.Controller;
using Poker.View;

namespace Poker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PokerModel model = new PokerModel();
            GameForm view = new GameForm();
            _ = new PokerController(model, view);
            Application.Run(view);
        }
    }
}
