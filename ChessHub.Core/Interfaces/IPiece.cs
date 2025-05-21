using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IPiece
{
    public PieceType PieceType { get; init; }
    public SideDesignation Side { get; init; }
    public int X { get; }
    public int Y { get; }
    public bool IsCaptured { get; }
    public List<IMove> PossibleMoves { get; }
}

public enum PieceType
{
    Pawn,
    Knight,
    Bishop,
    Rook,
    Queen,
    King
}
