namespace Ex05.ReverseTicTacToeUI.Repositories
{
    internal static class UserMessagesRepo
    {
        private static readonly string m_TieMessage = @"Tie!
Would you like to play another round?";

        private static readonly string m_WinMessage = @"The Winner is {0}!
Would you like to play another round?";

        internal static string GenerateTieMessage()
        {
            return m_TieMessage;
        }

        internal static string GenerateWinMessage(string i_WinnerName)
        {
            string winMessage = string.Format(m_WinMessage, i_WinnerName);

            return winMessage;
        }
    }
}