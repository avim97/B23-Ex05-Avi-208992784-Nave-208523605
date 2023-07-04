using Ex05.ReverseTicTacToeLogic.Models;

namespace Ex05.ReverseTicTacToeLogic.Infrastructure
{
    public class MoveValidator
    {
        private bool validateRange(int i_MaxValue, int i_NumberToCheck)
        {
            const int k_MinValue = 0;
            bool isWithinRange = (i_NumberToCheck >= k_MinValue && i_NumberToCheck <= i_MaxValue);

            return isWithinRange;
        }

        private bool validateMoveIsWithinBoardBounds(Coords i_Coords, Board i_Board)
        {
            int boardBoundMaxValue = i_Board.Height - 1;

            bool moveIsWithinBounds = validateRange(boardBoundMaxValue, i_Coords.X) && validateRange(boardBoundMaxValue, i_Coords.Y);

            return moveIsWithinBounds;
        }

        public eMoveInputValidationStatus ValidateMove(Coords i_Coords, Board i_Board)
        {
            eMoveInputValidationStatus moveInputStatus;

            if (!validateMoveIsWithinBoardBounds(i_Coords, i_Board))
            {
                moveInputStatus = eMoveInputValidationStatus.CoordsOutOfBounds;
            }
            else
            {
                Cell destinationCell = i_Board.Cells[i_Coords.X, i_Coords.Y];

                if (destinationCell.Marker == eCellMarker.X || destinationCell.Marker == eCellMarker.O)
                {
                    moveInputStatus = eMoveInputValidationStatus.CellIsTaken;
                }
                else
                {
                    moveInputStatus = eMoveInputValidationStatus.Valid;
                }
            }

            return moveInputStatus;
        }
    }
}
