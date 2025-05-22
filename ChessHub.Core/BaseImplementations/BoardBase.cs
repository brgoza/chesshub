using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations;

public class BoardBase : IBoard
{
<<<<<<< HEAD
    public ISquare[] Squares { get; private set; }

    private BoardBase(GameState gameState)
    {
        Squares = new ISquare[64];
    }



=======
    public List<ISquare> Squares { get; private set; }
    public IGame Game { get; init; }
    

    public BoardBase(IGame game)
    {
        Game = game;
        Squares = [];
    }

>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
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

<<<<<<< HEAD

=======
    
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
}
