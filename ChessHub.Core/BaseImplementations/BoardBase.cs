using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations;

public class BoardBase : IBoard
{
    public List<ISquare> Squares { get; private set; }
    public IGame Game { get; init; }
    

    public BoardBase(IGame game)
    {
        Game = game;
        Squares = [];
    }

    public virtual void InitializeBoard()
    {
        // Initialize the board with squares
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Squares.Add(new Square(x, y));
            }
        }
    }

    
}
