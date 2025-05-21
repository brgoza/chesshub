using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations.Pieces;

internal class King : PieceBase
{
    public override PieceType PieceType { get; init; } = PieceType.King;
    public List<IMove> PossibleMoves { get; set; } = [];
    public King(SideDesignation side, int x, int y)
    {
        Side = side;
        X = x;
        Y = y;
    }
    // Implement other methods and properties as needed
}
