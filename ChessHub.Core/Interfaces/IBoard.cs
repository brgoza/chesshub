<<<<<<< HEAD
﻿using ChessHub.Core.BaseImplementations;
using System;
=======
﻿using System;
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IBoard
{
<<<<<<< HEAD
    ISquare[] Squares { get; }
    public ISquare GetSquare(int x, int y);
    public ISquare GetSquare(char rank, int file);
=======
    IGame Game { get; init; }
    IEnumerable<ISquare> Squares { get; }
    void InitializeBoard();
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
}

public interface ISquare
{
<<<<<<< HEAD
    IBoard Board { get; init; }
    int Index { get; init; }
    int X { get; }
    int Y { get; }
    SquareColor Color { get; init; }
}

public enum SquareColor
{
    White,
    Black
}
=======
    public int X { get; init; }
    public int Y { get; init; }
}
>>>>>>> cbaeca49b8d92f9e7d97fb027177f6bb6ad8c69f
