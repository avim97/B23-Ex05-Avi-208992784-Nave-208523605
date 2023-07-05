namespace Ex05.ReverseTicTacToeUI.Repositories
{
    internal static class UserMessagesRepo
    {
        private const string k_TieMessageFormat = @"Tie!
Would you like to play another round?";

        private const string k_WinMessageFormat = @"The Winner is {0}!
Would you like to play another round?";

        internal static string GenerateTieMessage()
        {
            return k_TieMessageFormat;
        }

        internal static string GenerateWinMessage(string i_WinnerName)
        {
            string winMessage = string.Format(k_WinMessageFormat, i_WinnerName);

            return winMessage;
        }
    }
}