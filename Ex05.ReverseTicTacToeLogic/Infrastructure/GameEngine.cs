using System;
using System.Collections.Generic;
using Ex05.ReverseTicTacToeLogic.Models;

namespace Ex05.ReverseTicTacToeLogic.Infrastructure
{
    public class GameEngine
    {
        private readonly MoveValidator r_MoveValidator;
        public List<Player> Players { get; }
        public PlayersTurnsManager TurnsManager { get; }
        public eGameStatuses GameSessionStatus { get; set; }
        public Board Board { get; set; }
        public string CurrentPlayer => TurnsManager.CurrentPlayer;

        public GameEngine()
        {
            TurnsManager = new PlayersTurnsManager();
            GameSessionStatus = eGameStatuses.Running;
            r_MoveValidator = new MoveValidator();
            Players = new List<Player>();
        }

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
            int numIdenticalMarkersInRow = 0, numIdenticalMarkersInColumn = 0, numIdenticalMarkersInDiagonal = 0, numIdenticalMarkersInAntiDiagonal = 0;

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
            bool boardIsFullyMarked = Board.MarkedCells == Board.Height * Board.Width;

            return boardIsFullyMarked;
        }

        public void ExecutePlayerMove(Player i_Player, Coords i_Coords)
        {
            markCell(i_Coords, i_Player.Marker);
        }

        public void ExecuteComputerMove(Player i_Player, out Coords o_ComputerMoveCoords)
        {
            Random randomMoveGenerator = new Random();
            int xCoords = randomMoveGenerator.Next(Board.Width);
            int yCoords = randomMoveGenerator.Next(Board.Height);

            while (!Board.Cells[xCoords, yCoords].Marker.Equals(eCellMarker.None))
            {
                xCoords = randomMoveGenerator.Next(Board.Width);
                yCoords = randomMoveGenerator.Next(Board.Height);
            }

            o_ComputerMoveCoords = new Coords(xCoords, yCoords);
            markCell(o_ComputerMoveCoords, i_Player.Marker);
            
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
            for (int i = 0; i < Board.Width; i++)
            {
                for (int j = 0; j < Board.Height; j++)
                {
                    Board.Cells[i, j].Marker = eCellMarker.None;
                }
            }
        }

        private void reInitializePlayersQueue()
        {
            TurnsManager.ClearQueue();

            foreach (Player player in Players)
            {
                TurnsManager.AddPlayer(player);
            }
        }

        public Player GetLastPlayer()
        {
            return TurnsManager.GetLastPlayer();
        }

        public eMoveInputValidationStatus ValidateMove(int i_XCoords, int i_YCoords)
        {
            Coords coordsToValidate = new Coords(i_XCoords, i_YCoords);
            return r_MoveValidator.ValidateMove(coordsToValidate, Board);
        }

        public void SwitchTurns()
        {
            TurnsManager.SwitchPlayersTurns();
        }

        public eMoveExecutionResult CheckPlayerMoveExecutionResult(Coords i_ModifiedCellCoords)
        {
            eMoveExecutionResult moveExecutionResult;
            bool sequenceFound = checkMarkSequence(i_ModifiedCellCoords);
            bool boardIsFullyMarked = checkIfBoardIsFullyMarked();

            if (sequenceFound)
            {
                moveExecutionResult = eMoveExecutionResult.Lose;
                Player winningPlayer = TurnsManager.GetLastPlayer();

                winningPlayer.Score++;
            }
            else if (boardIsFullyMarked)
            {
                moveExecutionResult = eMoveExecutionResult.Tie;
            }
            else
            {
                moveExecutionResult = eMoveExecutionResult.NoEffect;
            }

            GameSessionStatus = sequenceFound || boardIsFullyMarked ? eGameStatuses.Finished : eGameStatuses.Running;

            return moveExecutionResult;
        }

        public void ResetGameSession()
        {
            reInitializePlayersQueue();
            emptyBoard();
            Board.MarkedCells = 0;
        }

    }
}
