using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations.Pieces;

public abstract class PieceBase : IPiece
{
    public abstract PieceType PieceType { get; init; }
    public SideDesignation Side { get; init; }
    public ISquare? Square { get; set; }
    public bool IsActive => Square != null;
    public bool IsCaptured => !IsActive;
    
    public PieceBase(SideDesignation side, int x, int y)
    {
        Side = side;
        X = x;
        Y = y;
    }
    // Implement other methods and properties as needed
}
