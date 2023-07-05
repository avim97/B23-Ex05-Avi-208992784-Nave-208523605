using System;
using Ex05.ReverseTicTacToeUI.Controllers;

namespace Ex05.ReverseTicTacToeUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var formsController = new FormsController();

            formsController.Start();
        }
    }
}