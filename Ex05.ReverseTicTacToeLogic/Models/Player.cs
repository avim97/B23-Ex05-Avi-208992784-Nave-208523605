using System;

namespace Ex05.ReverseTicTacToeLogic.Models
{
    public class Player
    {
        public event Action<int> ScoreChanged;
        public event Action AfterPlay;

        public Player(string i_Name, eCellMarker i_Marker, ePlayerType i_PlayerType)
        {
            Name = i_Name;
            Marker = i_Marker;
            PlayerType = i_PlayerType;
            Score = 0;
        }

        private int m_Score;
        public int Score
        {
            get => m_Score;
            set
            {
                m_Score = value;
                OnScoreChanged();
            }
        }
        public string Name { get; }
        public eCellMarker Marker { get; }
        public ePlayerType PlayerType { get; }

        public void OnScoreChanged()
        {
            ScoreChanged?.Invoke(Score);
        }

        public void OnAfterPlay()
        {
            AfterPlay?.Invoke();
        }
    }
}