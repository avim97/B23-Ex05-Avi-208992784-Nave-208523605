using System;
using System.Collections.Generic;
using Ex05.ReverseTicTacToeLogic.Models;

namespace Ex05.ReverseTicTacToeLogic.Infrastructure
{
    public class GameEngine
    {
        public GameEngine()
        {
            TurnsManager = new PlayersTurnsManager();
            GameSessionStatus = eGameStatuses.Running;
            Players = new List<Player>();
        }

        public List<Player> Players { get; }
        public PlayersTurnsManager TurnsManager { get; }
        public eGameStatuses GameSessionStatus { get; set; }
        public Board Board { get; set; }
        public string CurrentPlayerName => TurnsManager.CurrentPlayerName;
        public ePlayerType CurrentPlayerType => TurnsManager.CurrentPlayer.PlayerType;

        private void markCell(Coords i_Coords, eCellMarker i_Marker)
        {
            int xCoords = i_Coords.X;
            int yCoords = i_Coords.Y;

            Board.Cells[xCoords, yCoords].Marker = i_Marker;
            Board.MarkedCells++;
        }

        private bool checkMarkSequence(Coords i_ModifiedCellCoords)
        {
            eCellMarker cellMarker = Board.Cells[i_ModifiedCellCoords.X, i_ModifiedCellCoords.Y].Marker;
            int maxNumCellsInSequence = Board.Width;
            int numIdenticalMarkersInRow = 0,
                numIdenticalMarkersInColumn = 0,
                numIdenticalMarkersInDiagonal = 0,
                numIdenticalMarkersInAntiDiagonal = 0;

            for (int i = 0; i < maxNumCellsInSequence; i++)
            {
                if (Board.Cells[i, i_ModifiedCellCoords.Y].Marker.Equals(cellMarker))
                {
                    numIdenticalMarkersInRow++;
                }

                if (Board.Cells[i_ModifiedCellCoords.X, i].Marker.Equals(cellMarker))
                {
                    numIdenticalMarkersInColumn++;
                }

                if (Board.Cells[i, i].Marker == cellMarker)
                {
                    numIdenticalMarkersInDiagonal++;
                }

                if (Board.Cells[i, Board.Height - i - 1].Marker.Equals(cellMarker))
                {
                    numIdenticalMarkersInAntiDiagonal++;
                }
            }

            List<int> numIdenticalMarkersInSequences = new List<int>
            {
                numIdenticalMarkersInRow,
                numIdenticalMarkersInColumn,
                numIdenticalMarkersInDiagonal,
                numIdenticalMarkersInAntiDiagonal
            };

            bool sequenceFound = numIdenticalMarkersInSequences.Contains(maxNumCellsInSequence);

            return sequenceFound;
        }

        private bool checkIfBoardIsFullyMarked()
        {
            var boardIsFullyMarked = Board.MarkedCells == Board.Height * Board.Width;

            return boardIsFullyMarked;
        }

        public void ExecutePlayerMove(Coords i_Coords)
        {
            Player currentPlayer = TurnsManager.CurrentPlayer;

            markCell(i_Coords, currentPlayer.Marker);
            currentPlayer.OnAfterPlay();
            SwitchTurns();
        }

        public void ExecuteComputerMove(out Coords o_ChosenCellCoords)
        {
            Player computer = TurnsManager.CurrentPlayer;
            Random randomMoveGenerator = new Random();
            int xCoords = randomMoveGenerator.Next(Board.Width);
            int yCoords = randomMoveGenerator.Next(Board.Height);

            while (Board.Cells[xCoords, yCoords].Marker != eCellMarker.None)
            {
                xCoords = randomMoveGenerator.Next(Board.Width);
                yCoords = randomMoveGenerator.Next(Board.Height);
            }

            o_ChosenCellCoords = new Coords(xCoords, yCoords);
            markCell(o_ChosenCellCoords, computer.Marker);
            SwitchTurns();
        }

        public void SetGamePlayers(string i_FirstPlayerName, string i_SecondPlayerName, bool i_IsAiMatch)
        {
            List<Player> playerList = createPlayerEntities(i_FirstPlayerName, i_SecondPlayerName, i_IsAiMatch);

            foreach (Player player in playerList)
            {
                Players.Add(player);
                TurnsManager.AddPlayer(player);
            }
        }

        private List<Player> createPlayerEntities(string i_FirstPlayerName, string i_SecondPlayerName, bool i_IsAiMatch)
        {
            Player firstPlayer = new Player(i_FirstPlayerName, eCellMarker.X, ePlayerType.Human);
            ePlayerType secondPlayerType = i_IsAiMatch ? ePlayerType.Computer : ePlayerType.Human;
            Player secondPlayer = new Player(i_SecondPlayerName, eCellMarker.O, secondPlayerType);
            List<Player> playerList = new List<Player> { firstPlayer, secondPlayer };

            return playerList;
        }

        public void InitializeBoard(int i_BoardSize)
        {
            Board = new Board(i_BoardSize);
        }

        private void emptyBoard()
        {
            Board.ReinitializeCells();
        }

        private void reInitializePlayersQueue()
        {
            TurnsManager.ClearQueue();

            foreach (var player in Players)
            {
                TurnsManager.AddPlayer(player);
            }
        }

        public void SwitchTurns()
        {
            TurnsManager.SwitchPlayersTurns();
        }

        public eMoveResult CheckPlayerMoveExecutionResult(Coords i_ModifiedCellCoords)
        {
            eMoveResult moveResult;
            bool sequenceFound = checkMarkSequence(i_ModifiedCellCoords);
            bool boardIsFullyMarked = checkIfBoardIsFullyMarked();

            if (sequenceFound)
            {
                moveResult = eMoveResult.Lose;
                Player winningPlayer = TurnsManager.CurrentPlayer;

                winningPlayer.Score++;
            }
            else if (boardIsFullyMarked)
            {
                moveResult = eMoveResult.Tie;
            }
            else
            {
                moveResult = eMoveResult.NoEffect;
            }

            GameSessionStatus = sequenceFound || boardIsFullyMarked ? eGameStatuses.Finished : eGameStatuses.Running;

            return moveResult;
        }

        public void ResetGameSession()
        {
            reInitializePlayersQueue();
            emptyBoard();
            Board.MarkedCells = 0;
        }
    }
}