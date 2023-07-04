using Ex05.ReverseTicTacToeLogic.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ex05.ReverseTicTacToeLogic.Infrastructure
{
    public class PlayersTurnsManager
    {
        private readonly Queue<Player> r_PlayersQueue = new Queue<Player>();
        public string CurrentPlayer => r_PlayersQueue.Peek().Name;

        public void AddPlayer(Player i_Player)
        {
            r_PlayersQueue.Enqueue(i_Player);
        }
        public Player GetLastPlayer()
        {
            return r_PlayersQueue.Last();
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
