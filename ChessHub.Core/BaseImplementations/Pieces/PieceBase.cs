﻿using ChessHub.Core.Interfaces;
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
<<<<<<< HEAD
    public ISquare? Square { get; set; }
    public bool IsActive => Square != null;
    public bool IsCaptured => !IsActive;
    
=======
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsCaptured { get; private set; } = false;
    public List<IMove> PossibleMoves { get; set; }
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
    public PieceBase(SideDesignation side, int x, int y)
    {
        Side = side;
        X = x;
        Y = y;
    }
    // Implement other methods and properties as needed
}
