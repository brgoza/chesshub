using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHub.Core.Interfaces;

public interface IMove
{
    public SideDesignation Side { get; init; }
    public PieceType PieceType { get; init; }
    public int OriginX { get; init; }
    public int OriginY { get; init; }
    public int TargetX { get; init; }
    public int TargetY { get; init; }
}
