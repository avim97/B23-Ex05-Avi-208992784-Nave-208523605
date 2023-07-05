using System.Collections.Generic;
using Ex05.ReverseTicTacToeLogic.Models;

namespace Ex05.ReverseTicTacToeLogic.Infrastructure
{
    public class PlayersTurnsManager
    {
        private readonly Queue<Player> r_PlayersQueue = new Queue<Player>();
        public string CurrentPlayerName => r_PlayersQueue.Peek().Name;
        public Player CurrentPlayer => r_PlayersQueue.Peek();

        public void AddPlayer(Player i_Player)
        {
            r_PlayersQueue.Enqueue(i_Player);
        }

        public void SwitchPlayersTurns()
        {
            Player lastPlayer = r_PlayersQueue.Dequeue();

            r_PlayersQueue.Enqueue(lastPlayer);
        }

        public void ClearQueue()
        {
            r_PlayersQueue.Clear();
        }
    }
}