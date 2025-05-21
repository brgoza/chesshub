using ChessHub.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.BaseImplementations;

public class SquareBase : ISquare
{
    public SquareBase(int x, int y, SquareColor? color = null)
    {
        X = x;
        Y = y;
        Color = color ?? ((x + y) % 2 == 0 ? SquareColor.Black : SquareColor.White);
    }

    /// <summary>
    /// corresponds to rank (A=0, B=1, C=2, D=3, E=4, F=5, G=6, H=7)
    /// </summary>
    public int X { get; init; }
    /// <summary>
    /// corresponds to file (1=0, 2=1, 3=2, 4=3, 5=4, 6=5, 7=6, 8=7)
    /// </summary>
    public int Y { get; init; }
    public SquareColor Color { get; init; }
    public override string ToString()
    {
        return $"Square({X}, {Y})";
    }
}
