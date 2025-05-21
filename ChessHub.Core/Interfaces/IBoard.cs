using ChessHub.Core.BaseImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IBoard
{
    ISquare[] Squares { get; }
    public ISquare GetSquare(int x, int y);
    public ISquare GetSquare(char rank, int file);
}

public interface ISquare
{
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
