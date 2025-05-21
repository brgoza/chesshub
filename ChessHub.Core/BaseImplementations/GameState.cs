using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations;

public class GameState
{
    public GameState()
    {

    }
    public IBoard Board { get; } = null!;
    public ISide[] Sides { get; private set; } = new ISide[2];
    public ISide? CurrentSide { get; private set; } 
    public ISide? Winner { get; private set; } = null;

    public List<Move> MoveHistory { get; } = new();
}
