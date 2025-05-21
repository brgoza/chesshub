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
    private GameState()
    {

    }

    public static GameState CreateDefault()
    {
        return new GameState
        {
            Board = board,
            Sides = sides,
            CurrentSide = sides.Single(s => s.GoesFirst),
            MoveHistory = new List<Move>()
        };
    }

    public IBoard Board { get; init; } = null!;
    public ISide[] Sides { get; private set; } = new ISide[2];
    public ISide? CurrentSide { get; private set; } 
    public ISide? Winner { get; private set; } = null;

    public List<Move> MoveHistory { get; } = new();
}
