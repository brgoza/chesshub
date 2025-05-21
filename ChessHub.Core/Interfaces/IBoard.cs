using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IBoard
{
    IGame Game { get; init; }
    IEnumerable<ISquare> Squares { get; }
    void InitializeBoard();
}

public interface ISquare
{
    public int X { get; init; }
    public int Y { get; init; }
}